public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two 8-bit unsigned integers.
    /// </summary>
    /// <param name="this">The first of two 8-bit unsigned integers to compare.</param>
    /// <param name="value">The second of two 8-bit unsigned integers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static byte Min(this byte @this, byte value)
    {
        return System.Math.Min(@this, value);
    }
}