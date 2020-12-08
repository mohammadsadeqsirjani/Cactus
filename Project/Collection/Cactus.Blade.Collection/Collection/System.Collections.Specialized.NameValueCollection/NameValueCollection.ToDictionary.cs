using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extension
{
    /// <summary>
    ///     A NameValueCollection extension method that converts the @this to a dictionary.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IDictionary&lt;string,object&gt;</returns>
    public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
    {
        var dictionary = new Dictionary<string, object>();

        if (@this == null) return dictionary;

        foreach (var key in @this.AllKeys) dictionary.Add(key, @this[key]);

        return dictionary;
    }
}