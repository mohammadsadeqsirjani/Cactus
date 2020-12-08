using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is a week day.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is a week day, false if not.</returns>
    public static bool IsWeekDay(this DateTimeOffset @this)
    {
        return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
    }
}