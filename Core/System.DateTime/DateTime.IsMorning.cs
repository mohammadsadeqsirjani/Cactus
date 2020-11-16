public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is morning.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if morning, false if not.</returns>
    public static bool IsMorning(this System.DateTime @this)
    {
        return @this.TimeOfDay < new System.DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
    }
}