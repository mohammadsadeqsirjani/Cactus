public static partial class Extension
{
    /// <summary>
    ///     Converts the @this of the specified  to the equivalent 16-bit unsigned integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 16-bit unsigned integer equivalent to the @this of .</returns>
    public static ushort ToUInt16(this decimal @this)
    {
        return decimal.ToUInt16(@this);
    }
}