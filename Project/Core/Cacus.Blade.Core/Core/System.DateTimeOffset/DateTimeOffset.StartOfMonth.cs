public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that return a DateTimeOffset of the first day of the month with the time set to
    ///     "00:00:00:000". The first moment of the first day of the month.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffset of the first day of the month with the time set to "00:00:00:000".</returns>
    public static System.DateTimeOffset StartOfMonth(this System.DateTimeOffset @this)
    {
        return new System.DateTimeOffset(@this.Year, @this.Month, 1, 0, 0, 0, @this.Offset);
    }
}