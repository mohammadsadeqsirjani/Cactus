using System;

public static partial class Extension
{
    /// <summary>
    ///     Produces the full product of two 32-bit numbers.
    /// </summary>
    /// <param name="this">The first number to multiply.</param>
    /// <param name="value">The second number to multiply.</param>
    /// <returns>The number containing the product of the specified numbers.</returns>
    public static long BigMul(this int @this, int value)
    {
        return Math.BigMul(@this, value);
    }
}