public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that return a DateTime of the first day of the year with the time set to
    ///     "00:00:00:000". The first moment of the first day of the year.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the first day of the year with the time set to "00:00:00:000".</returns>
    public static System.DateTime StartOfYear(this System.DateTime @this)
    {
        return new System.DateTime(@this.Year, 1, 1);
    }
}