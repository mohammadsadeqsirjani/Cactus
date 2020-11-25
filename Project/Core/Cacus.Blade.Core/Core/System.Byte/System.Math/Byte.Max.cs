public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two 8-bit unsigned integers.
    /// </summary>
    /// <param name="this">The first of two 8-bit unsigned integers to compare.</param>
    /// <param name="value">The second of two 8-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static byte Max(this byte @this, byte value)
    {
        return System.Math.Max(@this, value);
    }
}