using System.Text;
using System.Web;

public static partial class Extension
{

    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified decoding object.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="encoding">The  that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static string UrlDecode(this byte[] bytes, Encoding encoding)
    {
        return HttpUtility.UrlDecode(bytes, encoding);
    }

    /// <summary>
    ///     Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the
    ///     specified position in the array, and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="offset">The position in the byte to begin decoding.</param>
    /// <param name="count">The number of bytes to decode.</param>
    /// <param name="e">The  object that specifies the decoding scheme.</param>
    /// <returns>A decoded string.</returns>
    public static string UrlDecode(this byte[] bytes, int offset, int count, Encoding e)
    {
        return HttpUtility.UrlDecode(bytes, offset, count, e);
    }
}
