using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the absolute value of a single-precision floating-point number.
    /// </summary>
    /// <param name="this">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A single-precision floating-point number, x, such that 0 ? x ?.</returns>
    public static float Abs(this float @this)
    {
        return Math.Abs(@this);
    }
}