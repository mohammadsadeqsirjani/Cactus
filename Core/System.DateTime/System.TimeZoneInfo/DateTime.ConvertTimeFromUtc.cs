public static partial class Extension
{
    /// <summary>
    ///     Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.
    /// </summary>
    /// <param name="this">The Coordinated Universal Time (UTC).</param>
    /// <param name="destinationTimeZone">The time zone to convert  to.</param>
    /// <returns>
    ///     The date and time in the destination time zone. Its  property is  if  is ; otherwise, its  property is .
    /// </returns>
    public static System.DateTime ConvertTimeFromUtc(this System.DateTime @this,
        System.TimeZoneInfo destinationTimeZone)
    {
        return System.TimeZoneInfo.ConvertTimeFromUtc(@this, destinationTimeZone);
    }
}