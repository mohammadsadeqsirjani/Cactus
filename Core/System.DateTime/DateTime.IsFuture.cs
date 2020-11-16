﻿public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is in the future.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if the value is in the future, false if not.</returns>
    public static bool IsFuture(this System.DateTime @this)
    {
        return @this > System.DateTime.Now;
    }
}