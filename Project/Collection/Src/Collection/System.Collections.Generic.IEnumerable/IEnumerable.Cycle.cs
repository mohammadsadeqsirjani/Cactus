using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Turns a finite sequence into a circular one, or equivalently,
    /// repeats the original sequence indefinitely.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">An <see cref="IEnumerable{T}"/> to cycle through.</param>
    /// <returns>An infinite sequence cycling through the given sequence.</returns>
    public static IEnumerable<TSource> Cycle<TSource>(this IEnumerable<TSource> @this)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(@this)} is null or empty");

        return CycleIterator(sources);
    }

    private static IEnumerable<TSource> CycleIterator<TSource>(IEnumerable<TSource> @this)
    {
        var elementBuffer = !(@this is ICollection<TSource> collection)
            ? new List<TSource>()
            : new List<TSource>(collection.Count);

        foreach (var element in @this)
        {
            yield return element;

            elementBuffer.Add(element);
        }

        if (elementBuffer.IsEmpty())
        {
            yield break;
        }

        var index = 0;

        while (true)
        {
            yield return elementBuffer[index];
            index = (index + 1) % elementBuffer.Count;
        }
    }
}