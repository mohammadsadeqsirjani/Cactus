using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>Enumerates merge distinct inner enumerable in this collection.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     An enumerator that allows foreach to be used to process merge distinct inner
    ///     enumerable in this collection.
    /// </returns>
    public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        var listItem = @this.ToList();

        var list = new List<T>();

        return listItem.Aggregate(list, (current, value) => current.Union(value).ToList());
    }
}
