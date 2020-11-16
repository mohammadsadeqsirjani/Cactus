using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Int64
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns a  that represents a specified time, where the specification is in units of ticks.
        /// </summary>
        /// <param name="this">A number of ticks that represent a time.</param>
        /// <returns>An object that represents .</returns>
        public static TimeSpan FromTicks(this long @this)
        {
            return TimeSpan.FromTicks(@this);
        }
    }
}
