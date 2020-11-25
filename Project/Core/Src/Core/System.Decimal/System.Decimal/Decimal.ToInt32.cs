public static partial class Extension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 32-bit signed integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 32-bit signed integer equivalent to the value of .</returns>
    public static int ToInt32(this decimal @this)
    {
        return decimal.ToInt32(@this);
    }
}