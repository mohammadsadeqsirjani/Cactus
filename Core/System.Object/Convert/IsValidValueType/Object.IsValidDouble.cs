public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid double.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid double, false if not.</returns>
    public static bool IsValidDouble(this object @this)
    {
        return @this == null || double.TryParse(@this.ToString(), out _);
    }
}