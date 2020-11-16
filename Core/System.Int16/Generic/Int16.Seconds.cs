using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Int16
{
    public static partial class Extension
    {
        /// <summary>
        ///     An Int16 extension method that seconds the given this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Seconds(this short @this)
        {
            return TimeSpan.FromSeconds(@this);
        }
    }
}
