using System;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that get the string before the specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value to search.</param>
    /// <returns>The string before the specified value.</returns>
    public static string GetBefore(this string @this, string value)
    {
        return @this.IndexOf(value, StringComparison.Ordinal) == -1
            ? ""
            : @this.Substring(0, @this.IndexOf(value, StringComparison.Ordinal));
    }
}