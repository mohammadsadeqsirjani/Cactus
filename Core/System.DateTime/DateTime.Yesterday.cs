public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that yesterdays the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>Yesterday date at same time.</returns>
    public static System.DateTime Yesterday(this System.DateTime @this)
    {
        return @this.AddDays(-1);
    }
}