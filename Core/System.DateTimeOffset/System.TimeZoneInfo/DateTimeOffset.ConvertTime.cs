// ReSharper disable once CheckNamespace
namespace Core.System.DateTimeOffset
{
    public static partial class Extension
    {
        /// <summary>
        ///     Converts a time to the time in a particular time zone.
        /// </summary>
        /// <param name="dateTimeOffset">The date and time to convert.</param>
        /// <param name="destinationTimeZone">The time zone to convert  to.</param>
        /// <returns>The date and time in the destination time zone.</returns>
        public static global::System.DateTimeOffset ConvertTime(this global::System.DateTimeOffset dateTimeOffset,
            global::System.TimeZoneInfo destinationTimeZone)
        {
            return global::System.TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
        }
    }
}
