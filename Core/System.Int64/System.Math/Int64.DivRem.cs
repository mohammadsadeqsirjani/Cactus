using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that div rem.
    /// </summary>
    /// <param name="this">this to act on.</param>
    /// <param name="value">The Int64 to process.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>An Int64.</returns>
    public static long DivRem(this long @this, long value, out long result)
    {
        return Math.DivRem(@this, value, out result);
    }
}