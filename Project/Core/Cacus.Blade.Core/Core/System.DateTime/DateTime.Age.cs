public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that ages the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An int.</returns>
    public static int Age(this System.DateTime @this)
    {
        if (System.DateTime.Today.Month < @this.Month ||
            System.DateTime.Today.Month == @this.Month &&
            System.DateTime.Today.Day < @this.Day)
        {
            return System.DateTime.Today.Year - @this.Year - 1;
        }
        return System.DateTime.Today.Year - @this.Year;
    }
}