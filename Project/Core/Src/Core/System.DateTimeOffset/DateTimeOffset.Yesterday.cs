public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that yesterdays the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>Yesterday date at same time.</returns>
    public static System.DateTimeOffset Yesterday(this System.DateTimeOffset @this)
    {
        return @this.AddDays(-1);
    }
}