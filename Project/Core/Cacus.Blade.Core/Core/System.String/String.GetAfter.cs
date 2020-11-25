using System;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that get the string after the specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value to search.</param>
    /// <returns>The string after the specified value.</returns>
    public static string GetAfter(this string @this, string value)
    {
        return @this.IndexOf(value, StringComparison.Ordinal) == -1
            ? ""
            : @this.Substring(@this.IndexOf(value, StringComparison.Ordinal) + value.Length);
    }
}