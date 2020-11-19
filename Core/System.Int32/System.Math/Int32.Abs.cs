using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the absolute this of a 32-bit signed integer.
    /// </summary>
    /// <param name="this">A number that is greater than , but less than or equal to .</param>
    /// <returns>A 32-bit signed integer, x, such that 0 ? x ?.</returns>
    public static int Abs(this int @this)
    {
        return Math.Abs(@this);
    }
}