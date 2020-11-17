public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid System.DateTimeOffset.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid System.DateTimeOffset, false if not.</returns>
    public static bool IsValidDateTimeOffSet(this object @this)
    {
        return @this == null || System.DateTimeOffset.TryParse(@this.ToString(), out _);
    }
}