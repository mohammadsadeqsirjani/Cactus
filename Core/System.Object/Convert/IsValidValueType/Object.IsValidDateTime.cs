public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid System.DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid System.DateTime, false if not.</returns>
    public static bool IsValidDateTime(this object @this)
    {
        return @this == null || System.DateTime.TryParse(@this.ToString(), out _);
    }
}