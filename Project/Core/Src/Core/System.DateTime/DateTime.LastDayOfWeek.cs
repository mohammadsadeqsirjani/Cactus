public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that last day of week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime.</returns>
    public static System.DateTime LastDayOfWeek(this System.DateTime @this)
    {
        return new System.DateTime(@this.Year, @this.Month, @this.Day).AddDays(6 - (int)@this.DayOfWeek);
    }
}