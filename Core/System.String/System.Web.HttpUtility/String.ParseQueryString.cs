using System.Collections.Specialized;
using System.Text;
using System.Web;

public static partial class Extension
{
    /// <summary>
    ///     Parses a query string into a  using  encoding.
    /// </summary>
    /// <param name="this">The query string to parse.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this string @this)
    {
        return HttpUtility.ParseQueryString(@this);
    }

    /// <summary>
    ///     Parses a query string into a  using the specified .
    /// </summary>
    /// <param name="this">The query string to parse.</param>
    /// <param name="encoding">The  to use.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this string @this, Encoding encoding)
    {
        return HttpUtility.ParseQueryString(@this, encoding);
    }
}