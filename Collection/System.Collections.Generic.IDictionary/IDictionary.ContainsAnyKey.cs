using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     An IDictionary&lt;TKey,TValue&gt; extension method that query if '@this' contains any key.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="keys">A variable-length parameters list containing keys.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
    {
        return keys.Any(@this.ContainsKey);
    }
}