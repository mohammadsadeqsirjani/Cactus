using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extension
{
    /// <summary>
    ///     An IDictionary&lt;string,string&gt; extension method that converts the @this to a name value collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a NameValueCollection.</returns>
    public static NameValueCollection ToNameValueCollection(this IDictionary<string, string> @this)
    {
        if (@this == null) return null;

        var collection = new NameValueCollection();

        foreach (var (key, value) in @this) collection.Add(key, value);

        return collection;
    }
}