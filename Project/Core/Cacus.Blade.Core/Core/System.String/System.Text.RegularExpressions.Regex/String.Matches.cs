using System.Text.RegularExpressions;

public static partial class Extension
{
    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression.
    /// </summary>
    /// <param name="this">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this string @this, string pattern)
    {
        return Regex.Matches(@this, pattern);
    }

    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression, using the
    ///     specified matching options.
    /// </summary>
    /// <param name="this">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this string @this, string pattern, RegexOptions options)
    {
        return Regex.Matches(@this, pattern, options);
    }
}