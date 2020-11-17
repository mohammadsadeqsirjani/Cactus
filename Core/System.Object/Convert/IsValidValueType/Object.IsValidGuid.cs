public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid System.Guid.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid System.Guid, false if not.</returns>
    public static bool IsValidGuid(this object @this)
    {
        return System.Guid.TryParse(@this.ToString(), out _);
    }
}