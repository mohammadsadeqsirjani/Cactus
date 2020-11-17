public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid long.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid long, false if not.</returns>
    public static bool IsValidInt64(this object @this)
    {
        return @this == null || long.TryParse(@this.ToString(), out _);
    }
}