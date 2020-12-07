using System;
using System.Diagnostics;

namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A system trace log writer
    /// </summary>
    public class TraceLogWriter : ILogWriter
    {
        private static readonly Lazy<TraceSource> TraceSource;

        /// <summary>
        /// Initializes the <see cref="TraceLogWriter"/> class.
        /// </summary>
        static TraceLogWriter()
        {
            TraceSource = new Lazy<TraceSource>(() =>
                new TraceSource(typeof(Logger).FullName ?? string.Empty, SourceLevels.Information));
        }

        /// <summary>
        /// Writes the specified LogData to the underlying logger.
        /// </summary>
        /// <param name="logData">The log data.</param>
        public void WriteLog(LogData logData)
        {
            var eventType = ToEventType(logData.LogLevel);

            if (logData.Parameters != null && logData.Parameters.Length > 0)
                TraceSource.Value.TraceEvent(eventType, 1, logData.Message, logData.Parameters);
            else
                TraceSource.Value.TraceEvent(eventType, 1, logData.Message);
        }

        private static TraceEventType ToEventType(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Trace => TraceEventType.Verbose,
                LogLevel.Debug => TraceEventType.Verbose,
                LogLevel.Info => TraceEventType.Information,
                LogLevel.Warn => TraceEventType.Warning,
                LogLevel.Error => TraceEventType.Error,
                LogLevel.Fatal => TraceEventType.Critical,
                _ => TraceEventType.Verbose
            };
        }
    }
}
