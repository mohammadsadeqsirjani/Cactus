using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Encodes a string.
    /// </summary>
    /// <param name="this">A string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string JavaScriptStringEncode(this string @this)
    {
        return HttpUtility.JavaScriptStringEncode(@this);
    }

    /// <summary>
    ///     Encodes a string.
    /// </summary>
    /// <param name="this">A string to encode.</param>
    /// <param name="addDoubleQuotes">
    ///     A value that indicates whether double quotation marks will be included around the
    ///     encoded string.
    /// </param>
    /// <returns>An encoded string.</returns>
    public static string JavaScriptStringEncode(this string @this, bool addDoubleQuotes)
    {
        return HttpUtility.JavaScriptStringEncode(@this, addDoubleQuotes);
    }
}