public static partial class Extension
{
    /// <summary>
    ///     Converts the @this of the specified  to the equivalent 16-bit signed integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 16-bit signed integer equivalent to .</returns>
    public static short ToInt16(this decimal @this)
    {
        return decimal.ToInt16(@this);
    }
}