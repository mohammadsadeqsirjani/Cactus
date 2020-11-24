public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is @this equal.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="timeToCompare">Date/Time of the @this to compare.</param>
    /// <returns>true if @this equal, false if not.</returns>
    public static bool IsTimeEqual(this System.DateTimeOffset @this, System.DateTimeOffset timeToCompare)
    {
        return @this.TimeOfDay == timeToCompare.TimeOfDay;
    }
}