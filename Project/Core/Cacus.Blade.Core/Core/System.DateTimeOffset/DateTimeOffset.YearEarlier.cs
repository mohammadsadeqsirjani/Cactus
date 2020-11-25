using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the same date (same Day, Month, Hour, Minute, Second etc) in the previous calendar year.
    /// If that day does not exist in previous year in same month, number of missing days is added to the last day in same month previous year.
    /// </summary>
    public static DateTimeOffset YearEarlier(this DateTimeOffset @this)
    {
        var previousYear = @this.Year - 1;
        var numberOfDaysInSameMonthPreviousYear = DateTime.DaysInMonth(previousYear, @this.Month);

        if (numberOfDaysInSameMonthPreviousYear >= @this.Day)
            return new DateTimeOffset(previousYear, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second,
                @this.Offset);
        var differenceInDays = @this.Day - numberOfDaysInSameMonthPreviousYear;
        var dateTime = new DateTimeOffset(previousYear, @this.Month, numberOfDaysInSameMonthPreviousYear, @this.Hour,
            @this.Minute, @this.Second, @this.Offset);
        return dateTime + differenceInDays.Days();

    }
}
