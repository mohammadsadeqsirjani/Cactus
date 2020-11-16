using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Double
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns a  that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="this">A number of milliseconds.</param>
        /// <returns>An object that represents .</returns>
        public static TimeSpan FromMilliseconds(this double @this)
        {
            return TimeSpan.FromMilliseconds(@this);
        }
    }
}
