public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid short.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid short, false if not.</returns>
    public static bool IsValidInt16(this object @this)
    {
        return @this == null || short.TryParse(@this.ToString(), out _);
    }
}