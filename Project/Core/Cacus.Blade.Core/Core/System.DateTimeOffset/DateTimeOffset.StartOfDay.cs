public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that return a DateTimeOffset with the time set to "00:00:00:000". The first moment of
    ///     the day.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffset of the day with the time set to "00:00:00:000".</returns>
    public static System.DateTimeOffset StartOfDay(this System.DateTimeOffset @this)
    {
        return new System.DateTimeOffset(@this.Year, @this.Month, @this.Day, 0, 0, 0, @this.Offset);
    }
}