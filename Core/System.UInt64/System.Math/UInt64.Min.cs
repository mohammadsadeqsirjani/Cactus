using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two 64-bit unsigned integers.
    /// </summary>
    /// <param name="this">The first of two 64-bit unsigned integers to compare.</param>
    /// <param name="value">The second of two 64-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller.</returns>
    public static ulong Min(this ulong @this, ulong value)
    {
        return Math.Min(@this, value);
    }
}
