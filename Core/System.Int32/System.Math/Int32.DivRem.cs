using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int32 extension method that div rem.
    /// </summary>
    /// <param name="this">this to act on.</param>
    /// <param name="value">The Int32 to process.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>An Int32.</returns>
    public static int DivRem(this int @this, int value, out int result)
    {
        return Math.DivRem(@this, value, out result);
    }
}