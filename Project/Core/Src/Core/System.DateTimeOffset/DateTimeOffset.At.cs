using System;

public static partial class Extension
{
    /// <summary>
    ///     Sets the time of the @this date with minute precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <returns>A DateTime.</returns>
    public static DateTimeOffset At(this DateTimeOffset @this, int hour, int minute)
    {
        // ReSharper disable once IntroduceOptionalParameters.Global
        return At(@this, hour, minute, 0);
    }

    /// <summary>
    ///     Sets the time of the @this date with minute precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="offset">The offset</param>
    /// <returns>A DateTime.</returns>
    public static DateTimeOffset At(this DateTimeOffset @this, int hour, int minute, TimeSpan offset)
    {
        // ReSharper disable once IntroduceOptionalParameters.Global
        return At(@this, hour, minute, 0, offset);
    }

    /// <summary>
    ///     Sets the time of the @this date with second precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <returns>A DateTime.</returns>
    public static DateTimeOffset At(this DateTimeOffset @this, int hour, int minute, int second)
    {
        return At(@this, hour, minute, second, TimeSpan.Zero);
    }


    /// <summary>
    ///     Sets the time of the @this date with millisecond precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <param name="offset">The timespan</param>
    /// <returns>A DateTime.</returns>
    public static DateTimeOffset At(this DateTimeOffset @this, int hour, int minute, int second, TimeSpan offset)
    {
        return new DateTimeOffset(@this.Year, @this.Month, @this.Day, hour, minute, second, offset);
    }
}