public static partial class Extension
{
    /// <summary>
    ///     Converts the value of the specified  to the equivalent single-precision floating-point number.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A single-precision floating-point number equivalent to the value of .</returns>
    public static float ToSingle(this decimal @this)
    {
        return decimal.ToSingle(@this);
    }
}