using System;
public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffSet extension method that return a DateTimeOffSet of the last day of the month with the time set to
    ///     "23:59:59:999". The last moment of the last day of the month.  Use "DateTimeOffSet" column type in sql to keep the
    ///     precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffSet of the last day of the month with the time set to "23:59:59:999".</returns>
    public static DateTimeOffset EndOfMonth(this DateTimeOffset @this)
    {
        return new DateTimeOffset(@this.Year, @this.Month, 1, 0, 0, 0, @this.Offset)
            .AddMonths(1)
            .Subtract(new TimeSpan(0, 0, 0, 1));
    }
}