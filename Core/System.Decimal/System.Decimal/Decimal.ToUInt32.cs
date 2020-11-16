public static partial class Extension
{
    /// <summary>
    ///     Converts the @this of the specified  to the equivalent 32-bit unsigned integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 32-bit unsigned integer equivalent to the @this of .</returns>
    public static uint ToUInt32(this decimal @this)
    {
        return decimal.ToUInt32(@this);
    }
}