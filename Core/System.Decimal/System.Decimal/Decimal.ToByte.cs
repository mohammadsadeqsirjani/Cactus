public static partial class Extension
{
    /// <summary>
    ///     Converts the @this of the specified  to the equivalent 8-bit unsigned integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>An 8-bit unsigned integer equivalent to .</returns>
    public static byte ToByte(this decimal @this)
    {
        return decimal.ToByte(@this);
    }
}