﻿namespace Logging
{
    public interface ILoggerConfiguration
    {
        bool IsLoggingEnabled { get; }
        LogLevel LoggingLevel { get; }
    }
}
