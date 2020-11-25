public static partial class Extension
{
    /// <summary>
    ///     Converts the specified Windows file time to an equivalent UTC time.
    /// </summary>
    /// <param name="fileTime">A Windows file time expressed in ticks.</param>
    /// <returns>
    ///     An object that represents the UTC time equivalent of the date and time represented by the  parameter.
    /// </returns>
    public static System.DateTime FromFileTimeUtc(this long fileTime)
    {
        return System.DateTime.FromFileTimeUtc(fileTime);
    }
}