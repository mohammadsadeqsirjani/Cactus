using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that return a DateTimeOffset of the last day of the year with the time set to
    ///     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
    ///     precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffset of the last day of the year with the time set to "23:59:59:999".</returns>
    public static DateTimeOffset EndOfYear(this DateTimeOffset @this)
    {
        return new DateTimeOffset(@this.Year, 1, 1, 0, 0, 0, @this.Offset)
            .AddYears(1)
            .Subtract(new TimeSpan(0, 0, 0, 1));
    }
}