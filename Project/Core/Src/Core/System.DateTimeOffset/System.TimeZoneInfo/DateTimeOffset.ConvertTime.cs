public static partial class Extension
{
    /// <summary>
    ///     Converts a time to the time in a particular time zone.
    /// </summary>
    /// <param name="dateTimeOffset">The date and time to convert.</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static System.DateTimeOffset ConvertTime(this System.DateTimeOffset dateTimeOffset,
        System.TimeZoneInfo destinationTimeZone)
    {
        return System.TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
    }
}