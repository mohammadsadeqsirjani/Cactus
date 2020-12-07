using System;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A factory for creating <see cref="ILogger"/> instances using <typeparamref name="T"/> as the name of the logger.
    /// </summary>
    /// <typeparam name="T">The type used to name the <see cref="ILogger"/>.</typeparam>
    public class LoggerFactory<T> : ILoggerFactory<T>
    {
        // lazy singleton of logger
        private static readonly Lazy<ILogger> Logger = new Lazy<ILogger>(Blade.Logger.Logger.CreateLogger<T>);

        /// <summary>
        /// Create an instance of <see cref="ILogger" /> using <typeparamref name="T" /> as the logger name.
        /// </summary>
        /// <returns>
        /// An instance of <see cref="ILogger" />.
        /// </returns>
        public ILogger CreateLogger()
        {
            return Logger.Value;
        }
    }
}
