using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns a  that represents a specified number of days, where the specification is accurate to the nearest
    ///     millisecond.
    /// </summary>
    /// <param name="this">A number of days, accurate to the nearest millisecond.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromDays(this double @this)
    {
        return TimeSpan.FromDays(@this);
    }
}