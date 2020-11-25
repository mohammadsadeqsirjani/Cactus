public static partial class Extension
{
    /// <summary>
    ///     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>The date and time in the destination time zone.</returns>
    public static System.DateTime ConvertTimeBySystemTimeZoneId(this System.DateTime @this,
        string destinationTimeZoneId)
    {
        return System.TimeZoneInfo.ConvertTimeBySystemTimeZoneId(@this, destinationTimeZoneId);
    }

    /// <summary>
    ///     Converts a time from one time zone to another based on time zone identifiers.
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <param name="sourceTimeZoneId">The identifier of the source time zone.</param>
    /// <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
    /// <returns>
    ///     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
    /// </returns>
    public static System.DateTime ConvertTimeBySystemTimeZoneId(this System.DateTime @this,
        string sourceTimeZoneId, string destinationTimeZoneId)
    {
        return System.TimeZoneInfo.ConvertTimeBySystemTimeZoneId(@this, sourceTimeZoneId,
            destinationTimeZoneId);
    }
}