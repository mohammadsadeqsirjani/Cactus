namespace Cactus.Blade.Logger
{
    /// <summary>
    /// A factory for creating <see cref="ILogger"/> instances using <typeparamref name="T"/> as the name of the logger.
    /// </summary>
    /// <typeparam name="T">The type used to name the <see cref="ILogger"/>.</typeparam>
    public interface ILoggerFactory<T>
    {
        /// <summary>
        /// Create an instance of <see cref="ILogger"/> using <typeparamref name="T"/> as the logger name.
        /// </summary>
        /// <returns>An instance of <see cref="ILogger"/>.</returns>
        ILogger CreateLogger();
    }
}