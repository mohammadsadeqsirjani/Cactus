using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A logger class for starting log messages.
    /// </summary>
    public sealed class Logger : ILogger
    {
        private static ILogWriter _logWriter;

        private static readonly ObjectPool<LogBuilder> ObjectPool;

        private static readonly ThreadLocal<IPropertyContext> _threadProperties;


        private static readonly Lazy<IPropertyContext> _globalProperties;

        private readonly Lazy<IPropertyContext> _properties;


        /// <summary>
        /// Initializes the <see cref="Logger"/> class.
        /// </summary>
        static Logger()
        {
            _globalProperties = new Lazy<IPropertyContext>(CreateGlobal);


            _threadProperties = new ThreadLocal<IPropertyContext>(CreateLocal);
            _logWriter = new TraceLogWriter();

            ObjectPool = new ObjectPool<LogBuilder>(() => new LogBuilder(_logWriter, ObjectPool), 25);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
            _properties = new Lazy<IPropertyContext>(() => new PropertyContext());
        }


        /// <summary>
        /// Gets the global property context.  All values are copied to each log on write.
        /// </summary>
        /// <value>
        /// The global property context.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static IPropertyContext GlobalProperties => _globalProperties.Value;

        /// <summary>
        /// Gets the thread-local property context.  All values are copied to each log on write.
        /// </summary>
        /// <value>
        /// The thread-local property context.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static IPropertyContext ThreadProperties => _threadProperties.Value;

        /// <summary>
        /// Gets the logger initial default properties.  All values are copied to each log.
        /// </summary>
        /// <value>
        /// The logger initial default properties.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public IPropertyContext Properties => _properties.Value;

        /// <summary>
        /// Gets the logger name.
        /// </summary>
        /// <value>
        /// The logger name.
        /// </value>
        public string Name { get; set; }


        /// <summary>
        /// Start a fluent <see cref="LogBuilder" /> with the specified <see cref="LogLevel" />.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        public static ILogBuilder Log(LogLevel logLevel, [CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(logLevel, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogBuilder" /> with the specified <see cref="LogLevel" />.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Log(LogLevel logLevel)
        {
            return CreateBuilder(logLevel);
        }


        /// <summary>
        /// Start a fluent <see cref="LogBuilder" /> with the computed <see cref="LogLevel" />.
        /// </summary>
        /// <param name="logLevelFactory">The log level factory.</param>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        public static ILogBuilder Log(Func<LogLevel> logLevelFactory, [CallerFilePath] string callerFilePath = null)
        {
            var logLevel = logLevelFactory?.Invoke() ?? LogLevel.Debug;

            return CreateBuilder(logLevel, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogBuilder" /> with the computed <see cref="LogLevel" />.
        /// </summary>
        /// <param name="logLevelFactory">The log level factory.</param>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Log(Func<LogLevel> logLevelFactory)
        {
            var logLevel = logLevelFactory?.Invoke() ?? LogLevel.Debug;

            return CreateBuilder(logLevel);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Trace"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Trace([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Trace, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Trace" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Trace()
        {
            return CreateBuilder(LogLevel.Trace);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Debug"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Debug([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Debug, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Debug" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Debug()
        {
            return CreateBuilder(LogLevel.Debug);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Info"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Info([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Info, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Info" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Info()
        {
            return CreateBuilder(LogLevel.Info);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Warn"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Warn([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Warn, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Warn" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Warn()
        {
            return CreateBuilder(LogLevel.Warn);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Error"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Error([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Error, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Error" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Error()
        {
            return CreateBuilder(LogLevel.Error);
        }


        /// <summary>
        /// Start a fluent <see cref="LogLevel.Fatal"/> logger.
        /// </summary>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is the file path at the time of compile.</param>
        /// <returns>A fluent Logger instance.</returns>
        public static ILogBuilder Fatal([CallerFilePath] string callerFilePath = null)
        {
            return CreateBuilder(LogLevel.Fatal, callerFilePath);
        }

        /// <summary>
        /// Start a fluent <see cref="LogLevel.Fatal" /> logger.
        /// </summary>
        /// <returns>
        /// A fluent Logger instance.
        /// </returns>
        ILogBuilder ILogger.Fatal()
        {
            return CreateBuilder(LogLevel.Fatal);
        }


        /// <summary>
        /// Registers a <see langword="delegate"/> to write logs to.
        /// </summary>
        /// <param name="writer">The <see langword="delegate"/> to write logs to.</param>
        public static void RegisterWriter(Action<LogData> writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            var logWriter = new DelegateLogWriter(writer);
            RegisterWriter(logWriter);
        }

        /// <summary>
        /// Registers a ILogWriter to write logs to.
        /// </summary>
        /// <param name="writer">The ILogWriter to write logs to.</param>
        public static void RegisterWriter<TWriter>(TWriter writer)
            where TWriter : ILogWriter
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            if (writer.Equals(_logWriter))
                return;

            var current = _logWriter;
            if (Interlocked.CompareExchange(ref _logWriter, writer, current) != current)
                return;

            ObjectPool.Clear();

        }


        /// <summary>
        /// Creates a new <see cref="ILogger"/> using the specified fluent <paramref name="builder"/> action.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static ILogger CreateLogger(Action<LoggerCreateBuilder> builder)
        {
            var factory = new Logger();
            var factoryBuilder = new LoggerCreateBuilder(factory);

            builder(factoryBuilder);

            return factory;
        }

        /// <summary>
        /// Creates a new <see cref="ILogger"/> using the caller file name as the logger name.
        /// </summary>
        /// <returns></returns>
        public static ILogger CreateLogger([CallerFilePath] string callerFilePath = null)
        {
            return new Logger { Name = GetName(callerFilePath) };
        }

        /// <summary>
        /// Creates a new <see cref="ILogger" /> using the specified type as the logger name.
        /// </summary>
        /// <param name="type">The type to use as the logger name.</param>
        /// <returns></returns>
        public static ILogger CreateLogger(Type type)
        {
            return new Logger { Name = type.FullName };
        }

        /// <summary>
        /// Creates a new <see cref="ILogger" /> using the specified type as the logger name.
        /// </summary>
        /// <typeparam name="T">The type to use as the logger name.</typeparam>
        /// <returns></returns>
        public static ILogger CreateLogger<T>()
        {
            return CreateLogger(typeof(T));
        }


        private static ILogBuilder CreateBuilder(LogLevel logLevel, string callerFilePath)
        {
            var name = GetName(callerFilePath);

            var builder = ObjectPool.Allocate();
            builder
                .Reset()
                .Level(logLevel)
                .Logger(name);

            MergeProperties(builder);

            return builder;
        }

        private ILogBuilder CreateBuilder(LogLevel logLevel)
        {
            var builder = ObjectPool.Allocate();
            builder
                .Reset()
                .Level(logLevel);

            MergeProperties(builder);
            MergeDefaults(builder);

            return builder;
        }


        private static string GetName(string path)
        {
            path = GetFileName(path);
            if (path == null)
                return null;

            int i;

            return (i = path.LastIndexOf('.')) != -1 ? path.Substring(0, i) : path;
        }

        private static string GetFileName(string path)
        {
            if (path == null) return null;

            var length = path.Length;

            for (var i = length; --i >= 0;)
            {
                var ch = path[i];

                if (ch == '\\' || ch == '/' || ch == ':') return path.Substring(i + 1, length - i - 1);

            }

            return path;
        }

        private static IPropertyContext CreateLocal()
        {
            var propertyContext = new PropertyContext();
            propertyContext.Set("ThreadId", Thread.CurrentThread.ManagedThreadId);
            return propertyContext;
        }


        private static IPropertyContext CreateGlobal()
        {
            var propertyContext = new PropertyContext();
            propertyContext.Set("MachineName", Environment.MachineName);
            return propertyContext;
        }

        private static void MergeProperties(ILogBuilder builder)
        {
            if (_globalProperties.IsValueCreated)
                _globalProperties.Value.Apply(builder);

            if (_threadProperties.IsValueCreated)
                _threadProperties.Value.Apply(builder);

        }


        private ILogBuilder MergeDefaults(ILogBuilder builder)
        {
            if (!string.IsNullOrEmpty(Name)) builder.Logger(Name);

            if (_properties.IsValueCreated)
                _properties.Value.Apply(builder);
            return builder;
        }
    }
}
