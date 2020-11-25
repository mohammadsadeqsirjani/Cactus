public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid bool.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid bool, false if not.</returns>
    public static bool IsValidBoolean(this object @this)
    {
        return @this == null || bool.TryParse(@this.ToString(), out _);
    }
}