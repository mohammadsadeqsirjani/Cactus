using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two 16-bit unsigned integers.
    /// </summary>
    /// <param name="this">The first of two 16-bit unsigned integers to compare.</param>
    /// <param name="value">The second of two 16-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static ushort Max(this ushort @this, ushort value)
    {
        return Math.Max(@this, value);
    }
}