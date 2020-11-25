using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the absolute @this of a double-precision floating-point number.
    /// </summary>
    /// <param name="this">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A double-precision floating-point number, x, such that 0 ? x ?.</returns>
    public static double Abs(this double @this)
    {
        return Math.Abs(@this);
    }
}