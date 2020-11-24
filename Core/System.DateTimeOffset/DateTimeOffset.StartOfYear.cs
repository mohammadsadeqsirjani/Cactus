public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that return a DateTimeOffset of the first day of the year with the time set to
    ///     "00:00:00:000". The first moment of the first day of the year.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffset of the first day of the year with the time set to "00:00:00:000".</returns>
    public static System.DateTimeOffset StartOfYear(this System.DateTimeOffset @this)
    {
        return new System.DateTimeOffset(@this.Year, 1, 1, 0, 0, 0, @this.Offset);
    }
}