public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that tomorrows the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>Tomorrow date at same time.</returns>
    public static System.DateTime Tomorrow(this System.DateTime @this)
    {
        return @this.AddDays(1);
    }
}