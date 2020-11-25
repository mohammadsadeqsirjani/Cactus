using System;

public static partial class Extension
{
    /// <summary>
    ///     A System.DateTime extension method that ends of week.
    /// </summary>
    /// <param name="this">Date/Time of the @this.</param>
    /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
    /// <returns>A DateTime.</returns>
    public static DateTime EndOfWeek(this DateTime @this,
        DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        var end = @this;
        var endDayOfWeek = startDayOfWeek - 1;

        if (endDayOfWeek < 0) endDayOfWeek = DayOfWeek.Saturday;

        if (end.DayOfWeek != endDayOfWeek)
        {
            end = endDayOfWeek < end.DayOfWeek
                ? end.AddDays(7 - (end.DayOfWeek - endDayOfWeek))
                : end.AddDays(endDayOfWeek - end.DayOfWeek);
        }

        return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
    }
}