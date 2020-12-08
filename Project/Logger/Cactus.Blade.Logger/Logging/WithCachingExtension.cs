using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Logging
{
    public static class WithCachingExtension
    {
        private static readonly ConditionalWeakTable<ILoggerFactory, CachedLoggerFactory> Cache =
            new ConditionalWeakTable<ILoggerFactory, CachedLoggerFactory>();

        public static ILoggerFactory WithCaching(this ILoggerFactory loggerFactory)
        {
            return Cache.GetValue(loggerFactory, factory => new CachedLoggerFactory(factory));
        }

        private class CachedLoggerFactory : ILoggerFactory
        {
            private readonly ConcurrentDictionary<Tuple<string, Type>, ILogger> _cachedLoggers =
                new ConcurrentDictionary<Tuple<string, Type>, ILogger>();

            public CachedLoggerFactory(ILoggerFactory loggerFactory)
            {
                LoggerFactory = loggerFactory;
            }

            public ILoggerFactory LoggerFactory { get; }

            public TLogger Get<TLogger>(string categoryName = null) where TLogger : ILogger
            {
                return
                    (TLogger)_cachedLoggers.GetOrAdd(
                        Tuple.Create(categoryName, typeof(TLogger)),
                        t => LoggerFactory.Get<TLogger>(categoryName));
            }
        }
    }
}
