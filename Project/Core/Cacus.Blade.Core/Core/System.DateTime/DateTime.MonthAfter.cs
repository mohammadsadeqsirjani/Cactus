using System;


public static partial class Extension
{
    /// <summary>
    /// Increases supplied <see cref="DateTime"/> for 7 days ie returns the Next Week.
    /// </summary>
    public static DateTime MonthAfter(this DateTime @this)
    {
        var year = @this.Month == 12 ? @this.Year + 1 : @this.Year;

        var month = @this.Month == 12 ? 1 : @this.Month + 1;

        var firstDayOfNextMonth = @this.At(year, month, 1);

        var lastDayOfPreviousMonth = firstDayOfNextMonth.EndOfMonth().Day;

        var day = @this.Day > lastDayOfPreviousMonth ? lastDayOfPreviousMonth : @this.Day;

        return new DateTime(firstDayOfNextMonth.Year, firstDayOfNextMonth.Month, day, firstDayOfNextMonth.Hour,
            firstDayOfNextMonth.Minute, firstDayOfNextMonth.Second);
    }
}