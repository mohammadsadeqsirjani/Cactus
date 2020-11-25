using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the absolute value of an 8-bit signed integer.
    /// </summary>
    /// <param name="this">A number that is greater than , but less than or equal to .</param>
    /// <returns>An 8-bit signed integer, x, such that 0 ? x ?.</returns>
    public static sbyte Abs(this sbyte @this)
    {
        return Math.Abs(@this);
    }
}