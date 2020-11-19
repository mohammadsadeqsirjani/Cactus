using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two 8-bit signed integers.
    /// </summary>
    /// <param name="this">The first of two 8-bit signed integers to compare.</param>
    /// <param name="value">The second of two 8-bit signed integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static sbyte Max(this sbyte @this, sbyte value)
    {
        return Math.Max(@this, value);
    }
}