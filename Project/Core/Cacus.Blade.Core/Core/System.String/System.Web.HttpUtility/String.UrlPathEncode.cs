using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Encodes the path portion of a URL string for reliable HTTP transmission from the Web server to a client.
    /// </summary>
    /// <param name="this">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static string UrlPathEncode(this string @this)
    {
        return HttpUtility.UrlPathEncode(@this);
    }
}