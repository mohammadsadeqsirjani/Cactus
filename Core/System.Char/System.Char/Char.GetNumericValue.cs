public static partial class Extension
{
    /// <summary>
    ///     Converts the specified numeric Unicode @this to a double-precision floating point number.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <returns>The numeric value of  if that @this represents a number; otherwise, -1.0.</returns>
    public static double GetNumericValue(this char @this)
    {
        return char.GetNumericValue(@this);
    }
}
