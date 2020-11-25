public static partial class Extension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent double-precision floating-point number.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A double-precision floating-point number equivalent to .</returns>
    public static double ToDouble(this decimal @this)
    {
        return decimal.ToDouble(@this);
    }
}