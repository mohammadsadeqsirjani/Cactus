using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that query if '@this' contains any value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
    {
        return values.Any(@this.Contains);
    }
}