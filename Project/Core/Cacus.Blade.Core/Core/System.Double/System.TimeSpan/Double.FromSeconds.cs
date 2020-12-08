using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns a  that represents a specified number of seconds, where the specification is accurate to the nearest
    ///     millisecond.
    /// </summary>
    /// <param name="this">A number of seconds, accurate to the nearest millisecond.</param>
    /// <returns>An object that represents .</returns>
    public static TimeSpan FromSeconds(this double @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}