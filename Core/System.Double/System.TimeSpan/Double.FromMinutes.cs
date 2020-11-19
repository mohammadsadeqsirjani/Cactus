using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns a  that represents a specified number of minutes, where the specification is accurate to the nearest
    ///     millisecond.
    /// </summary>
    /// <param name="this">A number of minutes, accurate to the nearest millisecond.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromMinutes(this double @this)
    {
        return TimeSpan.FromMinutes(@this);
    }
}