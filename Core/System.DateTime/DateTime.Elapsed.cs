using System;
public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that elapsed the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Elapsed(this DateTime @this)
    {
        return DateTime.Now - @this;
    }
}