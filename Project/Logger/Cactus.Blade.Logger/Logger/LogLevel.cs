namespace Cactus.Blade.Logger
{
    /// <summary>
    /// Defines available log levels.
    /// </summary>
    public enum LogLevel : byte
    {
        /// <summary>Trace log level.</summary>
        Trace,
        /// <summary>Debug log level.</summary>
        Debug,
        /// <summary>Info log level.</summary>
        Info,
        /// <summary>Warn log level.</summary>
        Warn,
        /// <summary>Error log level.</summary>
        Error,
        /// <summary>Fatal log level.</summary>
        Fatal,
    }
}
