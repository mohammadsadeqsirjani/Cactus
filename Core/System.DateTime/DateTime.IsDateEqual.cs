public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is @this equal.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="dateToCompare">Date/Time of the @this to compare.</param>
    /// <returns>true if @this equal, false if not.</returns>
    public static bool IsDateEqual(this System.DateTime @this, System.DateTime dateToCompare)
    {
        return @this.Date == dateToCompare.Date;
    }
}