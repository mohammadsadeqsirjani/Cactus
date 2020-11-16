public static partial class Extension
{
    /// <summary>A GUID extension method that query if '@this' is empty.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    public static bool IsEmpty(this System.Guid @this)
    {
        return @this == System.Guid.Empty;
    }
}