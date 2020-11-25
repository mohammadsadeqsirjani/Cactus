using System.IO;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string HtmlEncode(this string @this)
    {
        return HttpUtility.HtmlEncode(@this);
    }

    /// <summary>
    ///     Converts a string into an HTML-encoded string, and returns the output as a  stream of output.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <param name="textWriter">A  output stream.</param>
    public static void HtmlEncode(this string @this, TextWriter textWriter)
    {
        HttpUtility.HtmlEncode(@this, textWriter);
    }
}