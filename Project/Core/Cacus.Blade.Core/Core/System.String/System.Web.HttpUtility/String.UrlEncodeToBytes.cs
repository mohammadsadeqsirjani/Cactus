using System.Text;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Converts a string into a URL-encoded array of bytes.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static byte[] UrlEncodeToBytes(this string @this)
    {
        return HttpUtility.UrlEncodeToBytes(@this);
    }

    /// <summary>
    ///     Converts a string into a URL-encoded array of bytes using the specified encoding object.
    /// </summary>
    /// <param name="this">The string to encode.</param>
    /// <param name="encoding">The  that specifies the encoding scheme.</param>
    /// <returns>An encoded array of bytes.</returns>
    public static byte[] UrlEncodeToBytes(this string @this, Encoding encoding)
    {
        return HttpUtility.UrlEncodeToBytes(@this, encoding);
    }
}