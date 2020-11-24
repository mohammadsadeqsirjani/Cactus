public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that tomorrows the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>Tomorrow date at same time.</returns>
    public static System.DateTimeOffset Tomorrow(this System.DateTimeOffset @this)
    {
        return @this.AddDays(1);
    }
}