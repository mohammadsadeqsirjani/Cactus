using System.IO;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Minimally converts a string to an HTML-encoded string.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string HtmlAttributeEncode(this string @this)
    {
        return HttpUtility.HtmlAttributeEncode(@this);
    }

    /// <summary>
    ///     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <param name="output">A  output stream.</param>
    public static void HtmlAttributeEncode(this string @this, TextWriter output)
    {
        HttpUtility.HtmlAttributeEncode(@this, output);
    }
}