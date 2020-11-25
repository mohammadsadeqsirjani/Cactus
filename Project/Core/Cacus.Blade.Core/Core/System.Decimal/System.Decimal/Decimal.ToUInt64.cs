public static partial class Extension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent 64-bit unsigned integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 64-bit unsigned integer equivalent to the value of .</returns>
    public static ulong ToUInt64(this decimal @this)
    {
        return decimal.ToUInt64(@this);
    }
}