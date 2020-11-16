using System.Web;

public static partial class Extension
{

    /// <summary>
    ///     Converts a URL-encoded array of bytes into a decoded array of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this byte[] bytes)
    {
        return HttpUtility.UrlDecodeToBytes(bytes);
    }

    /// <summary>
    ///     Converts a URL-encoded array of bytes into a decoded array of bytes, starting at the specified position in
    ///     the array and continuing for the specified number of bytes.
    /// </summary>
    /// <param name="bytes">The array of bytes to decode.</param>
    /// <param name="offset">The position in the byte array at which to begin decoding.</param>
    /// <param name="count">The number of bytes to decode.</param>
    /// <returns>A decoded array of bytes.</returns>
    public static byte[] UrlDecodeToBytes(this byte[] bytes, int offset, int count)
    {
        return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
    }
}

