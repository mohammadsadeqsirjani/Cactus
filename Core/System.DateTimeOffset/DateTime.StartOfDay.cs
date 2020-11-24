public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that return a DateTime with the time set to "00:00:00:000". The first moment of
    ///     the day.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the day with the time set to "00:00:00:000".</returns>
    public static System.DateTime StartOfDay(this System.DateTime @this)
    {
        return new System.DateTime(@this.Year, @this.Month, @this.Day);
    }
}