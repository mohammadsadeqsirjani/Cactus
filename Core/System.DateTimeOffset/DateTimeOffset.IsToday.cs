public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is today.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if today, false if not.</returns>
    public static bool IsToday(this System.DateTimeOffset @this)
    {
        return @this.Date == System.DateTime.Today;
    }
}