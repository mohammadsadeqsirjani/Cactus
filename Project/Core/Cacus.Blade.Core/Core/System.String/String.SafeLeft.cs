using System;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that left safe.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>A string.</returns>
    public static string SafeLeft(this string @this, int length)
    {
        return @this.Substring(0, Math.Min(length, @this.Length));
    }
}