public static partial class Extension
{
    /// <summary>
    ///     Converts the @this of the specified  to the equivalent 8-bit signed integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>An 8-bit signed integer equivalent to .</returns>
    public static sbyte ToSByte(this decimal @this)
    {
        return decimal.ToSByte(@this);
    }
}