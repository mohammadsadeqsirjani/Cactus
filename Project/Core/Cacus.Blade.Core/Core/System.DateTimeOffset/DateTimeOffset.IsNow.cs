public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is now.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if now, false if not.</returns>
    public static bool IsNow(this System.DateTimeOffset @this)
    {
        return @this == System.DateTimeOffset.Now;
    }
}