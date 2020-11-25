using System;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that right safe.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="length">The length.</param>
    /// <returns>A string.</returns>
    public static string SafeRight(this string @this, int length)
    {
        return @this.Substring(Math.Max(0, @this.Length - length));
    }
}