using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A fluent <see langword="interface"/> to build log messages.
    /// </summary>
    public sealed class LogBuilder : ILogBuilder
    {
        private readonly ILogWriter _writer;
        private readonly IObjectPool<LogBuilder> _objectPool;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogBuilder" /> class.
        /// </summary>
        /// <param name="writer">The delegate to write logs to.</param>
        /// <param name="objectPool">The object pool.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="writer" /> is <see langword="null" />.</exception>
        internal LogBuilder(ILogWriter writer, IObjectPool<LogBuilder> objectPool)
            : this(writer)
        {
            _objectPool = objectPool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogBuilder" /> class.
        /// </summary>
        /// <param name="writer">The delegate to write logs to.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="writer" /> is <see langword="null" />.</exception>
        public LogBuilder(ILogWriter writer)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
            LogData = new LogData();
        }


        /// <summary>
        /// Gets the log data that is being built.
        /// </summary>
        /// <value>
        /// The log data.
        /// </value>
        public LogData LogData { get; }

        /// <summary>
        /// Sets the level of the logging event.
        /// </summary>
        /// <param name="logLevel">The level of the logging event.</param>
        /// <returns></returns>
        public ILogBuilder Level(LogLevel logLevel)
        {
            LogData.LogLevel = logLevel;
            return this;
        }

        /// <summary>
        /// Sets the logger for the logging event.
        /// </summary>
        /// <param name="logger">The name of the logger.</param>
        /// <returns></returns>
        public ILogBuilder Logger(string logger)
        {
            LogData.Logger = logger;

            return this;
        }

        /// <summary>
        /// Sets the logger name using the generic type.
        /// </summary>
        /// <typeparam name="TLogger">The type of the logger.</typeparam>
        /// <returns></returns>
        public ILogBuilder Logger<TLogger>()
        {
            LogData.Logger = typeof(TLogger).FullName;

            return this;
        }

        /// <summary>
        /// Sets the log message on the logging event.
        /// </summary>
        /// <param name="message">The log message for the logging event.</param>
        /// <returns></returns>
        public ILogBuilder Message(string message)
        {
            LogData.Message = message;

            return this;
        }

        /// <summary>
        /// Sets the log message on the logging event using the return value of specified <see langword="delegate" />.
        /// </summary>
        /// <param name="messageFactory">The <see langword="delegate" /> to generate the method.</param>
        /// <returns></returns>
        public ILogBuilder Message(Func<string> messageFactory)
        {
            LogData.MessageFormatter = messageFactory;

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The object to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(string format, object arg0)
        {
            LogData.Message = format;
            LogData.Parameters = new[] { arg0 };

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to format.</param>
        /// <param name="arg1">The second object to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(string format, object arg0, object arg1)
        {
            LogData.Message = format;
            LogData.Parameters = new[] { arg0, arg1 };

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to format.</param>
        /// <param name="arg1">The second object to format.</param>
        /// <param name="arg2">The third object to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(string format, object arg0, object arg1, object arg2)
        {
            LogData.Message = format;
            LogData.Parameters = new[] { arg0, arg1, arg2 };

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to format.</param>
        /// <param name="arg1">The second object to format.</param>
        /// <param name="arg2">The third object to format.</param>
        /// <param name="arg3">The fourth object to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(string format, object arg0, object arg1, object arg2, object arg3)
        {
            LogData.Message = format;
            LogData.Parameters = new[] { arg0, arg1, arg2, arg3 };

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(string format, params object[] args)
        {
            LogData.Message = format;
            LogData.Parameters = args;

            return this;
        }

        /// <summary>
        /// Sets the log message and parameters for formatting on the logging event.
        /// </summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns></returns>
        public ILogBuilder Message(IFormatProvider provider, string format, params object[] args)
        {
            LogData.FormatProvider = provider;
            LogData.Message = format;
            LogData.Parameters = args;

            return this;
        }

        /// <summary>
        /// Sets a log context property on the logging event.
        /// </summary>
        /// <param name="name">The name of the context property.</param>
        /// <param name="value">The value of the context property.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">name</exception>
        public ILogBuilder Property(string name, object value)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            LogData.Properties ??= new Dictionary<string, object>();

            LogData.Properties[name] = value;

            return this;
        }

        /// <summary>
        /// Sets the exception information of the logging event.
        /// </summary>
        /// <param name="exception">The exception information of the logging event.</param>
        /// <returns></returns>
        public ILogBuilder Exception(Exception exception)
        {
            LogData.Exception = exception;

            return this;
        }


        /// <summary>
        /// Reset log data to default values.
        /// </summary>
        /// <returns></returns>
        internal ILogBuilder Reset()
        {
            LogData.Reset();

            return this;
        }

        /// <summary>
        /// Writes the log event to the underlying logger.
        /// </summary>
        /// <param name="callerMemberName">The method or property name of the caller to the method. This is set at by the compiler.</param>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is set at by the compiler.</param>
        /// <param name="callerLineNumber">The line number in the source file at which the method is called. This is set at by the compiler.</param>
        public void Write(
            [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null,
            [CallerLineNumber] int callerLineNumber = 0)
        {
            if (callerMemberName != null)
                LogData.MemberName = callerMemberName;
            if (callerFilePath != null)
                LogData.FilePath = callerFilePath;
            if (callerLineNumber != 0)
                LogData.LineNumber = callerLineNumber;

            _writer.WriteLog(LogData);

            _objectPool?.Free(this);
        }


        /// <summary>
        /// Writes the log event to the underlying logger if the condition delegate is true.
        /// </summary>
        /// <param name="condition">If condition is true, write log event; otherwise ignore event.</param>
        /// <param name="callerMemberName">The method or property name of the caller to the method. This is set at by the compiler.</param>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is set at by the compiler.</param>
        /// <param name="callerLineNumber">The line number in the source file at which the method is called. This is set at by the compiler.</param>
        public void WriteIf(
            Func<bool> condition,
            [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null,
            [CallerLineNumber] int callerLineNumber = 0)
        {
            if (condition == null || !condition()) return;

            Write(callerMemberName, callerFilePath, callerLineNumber);
        }

        /// <summary>
        /// Writes the log event to the underlying logger if the condition is true.
        /// </summary>
        /// <param name="condition">If condition is true, write log event; otherwise ignore event.</param>
        /// <param name="callerMemberName">The method or property name of the caller to the method. This is set at by the compiler.</param>
        /// <param name="callerFilePath">The full path of the source file that contains the caller. This is set at by the compiler.</param>
        /// <param name="callerLineNumber">The line number in the source file at which the method is called. This is set at by the compiler.</param>
        public void WriteIf(
            bool condition,
            [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null,
            [CallerLineNumber] int callerLineNumber = 0)
        {
            if (!condition) return;

            Write(callerMemberName, callerFilePath, callerLineNumber);
        }
    }
}
