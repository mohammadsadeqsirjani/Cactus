using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two single-precision floating-point numbers.
    /// </summary>
    /// <param name="this">The first of two single-precision floating-point numbers to compare.</param>
    /// <param name="value>The second of two single-precision floating-point numbers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller. If , , or both  and  are equal to ,  is returned.</returns>
    public static float Min(this float @this, float value)
    {
        return Math.Min(@this, value);
    }
}