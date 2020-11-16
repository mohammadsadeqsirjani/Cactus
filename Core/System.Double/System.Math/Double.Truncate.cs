using System;

public static partial class Extension
{
    /// <summary>
    ///     Calculates the integral part of a specified double-precision floating-point number.
    /// </summary>
    /// <param name="this">A number to truncate.</param>
    /// <returns>
    ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded, or
    ///     one of the values listed in the following table. Return value.
    /// </returns>
    public static double Truncate(this double @this)
    {
        return Math.Truncate(@this);
    }
}