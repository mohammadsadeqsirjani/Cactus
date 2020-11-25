using System.IO;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static string HtmlDecode(this string @this)
    {
        return HttpUtility.HtmlDecode(@this);
    }

    /// <summary>
    ///     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
    ///     stream.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <param name="textWriter">A  stream of output.</param>
    public static void HtmlDecode(this string @this, TextWriter textWriter)
    {
        HttpUtility.HtmlDecode(@this, textWriter);
    }
}