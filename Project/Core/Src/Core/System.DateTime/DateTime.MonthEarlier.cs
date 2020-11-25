using System;

public static partial class Extension
{
    /// <summary>
    /// Increases supplied <see cref="DateTime"/> for 7 days ie returns the Previous Month.
    /// </summary>
    public static DateTime MonthEarlier(this DateTime @this)
    {
        var year = @this.Month == 1 ? @this.Year - 1 : @this.Year;

        var month = @this.Month == 1 ? 12 : @this.Month - 1;

        var firstDayOfPreviousMonth = @this.At(year, month, 1);

        var lastDayOfPreviousMonth = firstDayOfPreviousMonth.EndOfMonth().Day;

        var day = @this.Day > lastDayOfPreviousMonth ? lastDayOfPreviousMonth : @this.Day;

        return new DateTime(firstDayOfPreviousMonth.Year, firstDayOfPreviousMonth.Month, day,
            firstDayOfPreviousMonth.Hour,
            firstDayOfPreviousMonth.Minute, firstDayOfPreviousMonth.Second);
    }
}