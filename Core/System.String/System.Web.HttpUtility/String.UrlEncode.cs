using System.Text;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Encodes a URL string.
    /// </summary>
    /// <param name="this">The text to encode.</param>
    /// <returns>An encoded string.</returns>
    public static string UrlEncode(this string @this)
    {
        return HttpUtility.UrlEncode(@this);
    }

    /// <summary>
    ///     Encodes a URL string using the specified encoding object.
    /// </summary>
    /// <param name="this">The text to encode.</param>
    /// <param name="encoding">The  object that specifies the encoding scheme.</param>
    /// <returns>An encoded string.</returns>
    public static string UrlEncode(this string @this, Encoding encoding)
    {
        return HttpUtility.UrlEncode(@this, encoding);
    }
}