using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffSet extension method that return a DateTimeOffSet with the time set to "23:59:59:999". The last moment of
    ///     the day. Use "DateTime2" column type in sql to keep the precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffSet of the day with the time set to "23:59:59:999".</returns>
    public static DateTimeOffset EndOfDay(this DateTimeOffset @this)
    {
        return new DateTimeOffset(@this.Year, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second, @this.Offset)
            .AddDays(1)
            .Subtract(new TimeSpan(0, 0, 0, 0, 1));
    }
}