using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Repeats the given sequence <paramref name="count"/> times.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">The sequence to repeat.</param>
    /// <param name="count">The number of times to repeat the sequence.</param>
    /// <returns>A repeated version of the original sequence.</returns>
    public static IEnumerable<TSource> Repeat<TSource>(this IEnumerable<TSource> @this, int count)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");
        if (count < 0) throw new ArgumentException($"{nameof(count)} must greater than zero");

        return RepeatIterator(sources, count);
    }

    private static IEnumerable<TSource> RepeatIterator<TSource>(this IEnumerable<TSource> @this, int count)
    {
        if (count == 0) yield break;

        var elementBuffer = !(@this is ICollection<TSource> collection)
            ? new List<TSource>()
            : new List<TSource>(collection.Count);

        foreach (var element in @this)
        {
            yield return element;

            elementBuffer.Add(element);
        }

        if (elementBuffer.IsEmpty()) yield break;

        for (var i = 0; i < count - 1; i++)
            foreach (var element in elementBuffer)
                yield return element;
    }
}