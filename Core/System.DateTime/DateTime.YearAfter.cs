using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>
    /// Returns the same date (same Day, Month, Hour, Minute, Second etc) in the next calendar year.
    /// If that day does not exist in next year in same month, number of missing days is added to the last day in same month next year.
    /// </summary>
    public static DateTime YearAfter(this DateTime @this)
    {
        var nextYear = @this.Year + 1;
        var numberOfDaysInSameMonthNextYear = DateTime.DaysInMonth(nextYear, @this.Month);

        if (numberOfDaysInSameMonthNextYear < @this.Day)
        {
            var differenceInDays = @this.Day - numberOfDaysInSameMonthNextYear;
            var dateTime = new DateTime(nextYear, @this.Month, numberOfDaysInSameMonthNextYear, @this.Hour,
                @this.Minute, @this.Second, @this.Millisecond, @this.Kind);
            return dateTime + differenceInDays.Days();
        }

        return new DateTime(nextYear, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second, @this.Millisecond,
            @this.Kind);
    }
}
