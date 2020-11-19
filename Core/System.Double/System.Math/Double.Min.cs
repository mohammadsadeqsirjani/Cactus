using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="this">The first of two double-precision floating-point numbers to compare.</param>
    /// <param name="value">The second of two double-precision floating-point numbers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller. If , , or both  and  are equal to ,  is returned.</returns>
    public static double Min(this double @this, double value)
    {
        return Math.Min(@this, value);
    }
}