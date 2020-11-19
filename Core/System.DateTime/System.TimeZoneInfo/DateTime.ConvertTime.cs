public static partial class Extension
{
    /// <summary>
    ///     Converts a time to the time in a particular time zone.
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static System.DateTime ConvertTime(this System.DateTime @this,
        System.TimeZoneInfo destinationTimeZone)
    {
        return System.TimeZoneInfo.ConvertTime(@this, destinationTimeZone);
    }

    /// <summary>
    ///     Converts a time from one time zone to another.
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <param name="sourceTimeZone">The time zone of .</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>
    ///     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
    /// </returns>
    public static System.DateTime ConvertTime(this System.DateTime @this,
        System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone)
    {
        return System.TimeZoneInfo.ConvertTime(@this, sourceTimeZone, destinationTimeZone);
    }
}