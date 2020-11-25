using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>
    /// Returns the same date (same Day, Month, Hour, Minute, Second etc) in the previous calendar year.
    /// If that day does not exist in previous year in same month, number of missing days is added to the last day in same month previous year.
    /// </summary>
    public static DateTime YearEarlier(this DateTime @this)
    {
        var previousYear = @this.Year - 1;
        var numberOfDaysInSameMonthPreviousYear = DateTime.DaysInMonth(previousYear, @this.Month);

        if (numberOfDaysInSameMonthPreviousYear < @this.Day)
        {
            var differenceInDays = @this.Day - numberOfDaysInSameMonthPreviousYear;
            var dateTime = new DateTime(previousYear, @this.Month, numberOfDaysInSameMonthPreviousYear, @this.Hour,
                @this.Minute, @this.Second, @this.Millisecond, @this.Kind);
            return dateTime + differenceInDays.Days();
        }

        return new DateTime(previousYear, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second,
            @this.Millisecond, @this.Kind);
    }
}
