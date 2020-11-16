public static partial class Extension
{
    /// <summary>A GUID extension method that queries if a not is empty.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a not is empty, false if not.</returns>
    public static bool IsNotEmpty(this System.Guid @this)
    {
        return @this != System.Guid.Empty;
    }
}