using System.Text.RegularExpressions;

public static partial class Extension
{
    /// <summary>
    ///     Searches the specified input string for the first occurrence of the specified regular expression.
    /// </summary>
    /// <param name="this">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>An object that contains information about the match.</returns>
    public static Match Match(this string @this, string pattern)
    {
        return Regex.Match(@this, pattern);
    }

    /// <summary>
    ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
    ///     matching options.
    /// </summary>
    /// <param name="this">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
    /// <returns>An object that contains information about the match.</returns>
    public static Match Match(this string @this, string pattern, RegexOptions options)
    {
        return Regex.Match(@this, pattern, options);
    }
}