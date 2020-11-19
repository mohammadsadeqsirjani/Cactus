public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid decimal.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid decimal, false if not.</returns>
    public static bool IsValidDecimal(this object @this)
    {
        return @this == null || decimal.TryParse(@this.ToString(), out _);
    }
}