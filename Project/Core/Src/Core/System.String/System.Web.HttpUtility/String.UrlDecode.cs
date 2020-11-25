using System.Text;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Converts a string that has been encoded for transmission in a URL into a decoded string.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <returns>A decoded string.</returns>
    public static string UrlDecode(this string @this)
    {
        return HttpUtility.UrlDecode(@this);
    }

    /// <summary>
    ///     Converts a URL-encoded string into a decoded string, using the specified encoding object.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <param name="encoding">The  that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static string UrlDecode(this string @this, Encoding encoding)
    {
        return HttpUtility.UrlDecode(@this, encoding);
    }
}