using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two single-precision floating-point numbers.
    /// </summary>
    /// <param name="this">The first of two single-precision floating-point numbers to compare.</param>
    /// <param name="value">The second of two single-precision floating-point numbers to compare.</param>
    /// <returns>Parameter  or , whichever is larger. If , or , or both  and  are equal to ,  is returned.</returns>
    public static float Max(this float @this, float value)
    {
        return Math.Max(@this, value);
    }
}