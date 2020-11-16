using System;
using System.Globalization;

// ReSharper disable once CheckNamespace
namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns a value indicating whether the specified date and @this is within the specified daylight saving @this
        ///     period.
        /// </summary>
        /// <param name="this">A date and @this.</param>
        /// <param name="daylightTimes">A daylight saving @this period.</param>
        /// <returns>true if  is in ; otherwise, false.</returns>
        [Obsolete]
        public static bool IsDaylightSavingTime(this global::System.DateTime @this, DaylightTime daylightTimes)
        {
            return global::System.TimeZone.IsDaylightSavingTime(@this, daylightTimes);
        }
    }
}
