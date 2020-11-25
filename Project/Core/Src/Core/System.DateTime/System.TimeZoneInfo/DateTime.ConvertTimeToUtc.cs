public static partial class Extension
{
    /// <summary>
    ///     Converts the current date and time to Coordinated Universal Time (UTC).
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <returns>
    ///     The Coordinated Universal Time (UTC) that corresponds to the  parameter. The  value&#39;s  property is always
    ///     set to .
    /// </returns>
    public static System.DateTime ConvertTimeToUtc(this System.DateTime @this)
    {
        return System.TimeZoneInfo.ConvertTimeToUtc(@this);
    }

    /// <summary>
    ///     Converts the time in a specified time zone to Coordinated Universal Time (UTC).
    /// </summary>
    /// <param name="this">The date and time to convert.</param>
    /// <param name="sourceTimeZone">The time zone of .</param>
    /// <returns>
    ///     The Coordinated Universal Time (UTC) that corresponds to the  parameter. The  object&#39;s  property is
    ///     always set to .
    /// </returns>
    public static System.DateTime ConvertTimeToUtc(this System.DateTime @this,
        System.TimeZoneInfo sourceTimeZone)
    {
        return System.TimeZoneInfo.ConvertTimeToUtc(@this, sourceTimeZone);
    }
}