using System;

public static partial class Extension
{
    /// <summary>
    /// Returns the same date (same Day, Month, Hour, Minute, Second etc) in the next calendar year.
    /// If that day does not exist in next year in same month, number of missing days is added to the last day in same month next year.
    /// </summary>
    public static DateTimeOffset YearAfter(this DateTimeOffset @this)
    {
        var nextYear = @this.Year + 1;
        var numberOfDaysInSameMonthNextYear = DateTime.DaysInMonth(nextYear, @this.Month);

        if (numberOfDaysInSameMonthNextYear >= @this.Day)
            return new DateTimeOffset(nextYear, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second,
                @this.Offset);

        var differenceInDays = @this.Day - numberOfDaysInSameMonthNextYear;
        var dateTime = new DateTimeOffset(nextYear, @this.Month, numberOfDaysInSameMonthNextYear, @this.Hour,
            @this.Minute, @this.Second, @this.Offset);

        return dateTime + differenceInDays.Days();
    }
}
