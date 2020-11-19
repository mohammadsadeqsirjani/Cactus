using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two 64-bit unsigned integers.
    /// </summary>
    /// <param name="this">The first of two 64-bit unsigned integers to compare.</param>
    /// <param name="value">The second of two 64-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static ulong Max(this ulong @this, ulong value)
    {
        return Math.Max(@this, value);
    }
}