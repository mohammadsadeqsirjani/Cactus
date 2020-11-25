using System.Text;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this string @this)
    {
        return HttpUtility.UrlDecodeToBytes(@this);
    }

    /// <summary>
    ///     Converts a URL-encoded string into a decoded array of bytes using the specified decoding object.
    /// </summary>
    /// <param name="this">The string to decode.</param>
    /// <param name="encoding">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this string @this, Encoding encoding)
    {
        return HttpUtility.UrlDecodeToBytes(@this, encoding);
    }
}
