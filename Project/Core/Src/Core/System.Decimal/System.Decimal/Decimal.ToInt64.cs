public static partial class Extension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 64-bit signed integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 64-bit signed integer equivalent to the value of .</returns>
    public static long ToInt64(this decimal @this)
    {
        return decimal.ToInt64(@this);
    }
}