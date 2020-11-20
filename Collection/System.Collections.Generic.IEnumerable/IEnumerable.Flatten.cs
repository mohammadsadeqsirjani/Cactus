using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Returns a flattened sequence that contains the concatenation of all the nested sequences' elements.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">A sequence of sequences to be flattened.</param>
    /// <returns>The concatenation of all the nested sequences' elements.</returns>
    public static IEnumerable<TSource> Flatten<TSource>(this IEnumerable<IEnumerable<TSource>> @this)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");

        return FlattenIterator(sources);
    }

    private static IEnumerable<TSource> FlattenIterator<TSource>(IEnumerable<IEnumerable<TSource>> @this)
    {
        return @this.SelectMany(array => array);
    }
}