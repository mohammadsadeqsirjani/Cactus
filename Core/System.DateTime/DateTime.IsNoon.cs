using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is noon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if now, false if not.</returns>
    public static bool IsNoon(this DateTime @this)
    {
        return @this == new DateTime(@this.Year, @this.Month, @this.Day, 12, 0, 0);
    }
}