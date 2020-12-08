using System;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that get the string between the two specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="before">The string before to search.</param>
    /// <param name="after">The string after to search.</param>
    /// <returns>The string between the two specified string.</returns>
    public static string GetBetween(this string @this, string before, string after)
    {
        var beforeStartIndex = @this.IndexOf(before, StringComparison.Ordinal);
        var startIndex = beforeStartIndex + before.Length;
        var afterStartIndex = @this.IndexOf(after, startIndex, StringComparison.Ordinal);

        return beforeStartIndex == -1 || afterStartIndex == -1
            ? ""
            : @this.Substring(startIndex, afterStartIndex - startIndex);
    }
}