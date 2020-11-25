public static partial class Extension
{
    /// <summary>
    ///     Sets the time of the @this date with minute precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <returns>A DateTime.</returns>
    public static System.DateTime SetTime(this System.DateTime @this, int hour, int minute)
    {
        // ReSharper disable once IntroduceOptionalParameters.Global
        return SetTime(@this, hour, minute, 0, 0);
    }

    /// <summary>
    ///     Sets the time of the @this date with second precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <returns>A DateTime.</returns>
    public static System.DateTime SetTime(this System.DateTime @this, int hour, int minute, int second)
    {
        return SetTime(@this, hour, minute, second, 0);
    }



    /// <summary>
    ///     Sets the time of the @this date with millisecond precision.
    /// </summary>
    /// <param name="this">The @this date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <param name="millisecond">The millisecond.</param>
    /// <returns>A DateTime.</returns>
    public static System.DateTime SetTime(this System.DateTime @this, int hour, int minute, int second, int millisecond)
    {
        return new System.DateTime(@this.Year, @this.Month, @this.Day, hour, minute, second, millisecond);
    }
}