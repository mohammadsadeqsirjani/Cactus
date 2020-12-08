using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two 32-bit signed integers.
    /// </summary>
    /// <param name="this">The first of two 32-bit signed integers to compare.</param>
    /// <param name="value">The second of two 32-bit signed integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static int Max(this int @this, int value)
    {
        return Math.Max(@this, value);
    }
}