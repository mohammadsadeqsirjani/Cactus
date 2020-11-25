using System;
using System.Globalization;

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
    public static bool IsDaylightSavingTime(this DateTime @this, DaylightTime daylightTimes)
    {
        return TimeZone.IsDaylightSavingTime(@this, daylightTimes);
    }
}