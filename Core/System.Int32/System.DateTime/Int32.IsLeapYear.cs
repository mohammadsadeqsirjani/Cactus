public static partial class Extension
{
    /// <summary>
    ///     Returns an indication whether the specified this is a leap this.
    /// </summary>
    /// <param name="this">A 4-digit this.</param>
    /// <returns>true if  is a leap this; otherwise, false.</returns>
    public static bool IsLeapYear(this int @this)
    {
        return System.DateTime.IsLeapYear(@this);
    }
}