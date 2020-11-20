using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Enumerates the specified <see cref="NameValueCollection"/>
    /// as a sequence of key-value pairs of type <see cref="KeyValuePair&lt;TKey,TValue&gt;"/>.
    /// </summary>
    /// <param name="this">The collection.</param>
    /// <returns>A sequence of key-value pairs of type <see cref="KeyValuePair&lt;TKey,TValue&gt;"/>.</returns>
    public static IEnumerable<KeyValuePair<string, string>> ToKeyValuePairs(this NameValueCollection @this)
    {
        if (@this == null) throw new ArgumentException($"{nameof(@this)} is null");

        return ToKeyValuePairsIterator(@this);
    }

    private static IEnumerable<KeyValuePair<string, string>> ToKeyValuePairsIterator(NameValueCollection @this)
    {
        return from string key in @this.Keys
               select new KeyValuePair<string, string>(key, @this[key]);
    }
}