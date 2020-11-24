public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that first day of week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime.</returns>
    public static System.DateTimeOffset FirstDayOfWeek(this System.DateTimeOffset @this)
    {
        return new System.DateTimeOffset(@this.Year, @this.Month, @this.Day, 0, 0, 0, @this.Offset)
            .AddDays(-(int)@this.DayOfWeek);
    }
}