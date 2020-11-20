using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Enumerates the specified input sequence and returns a new sequence
    /// which contains all input elements in random order.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">The sequence to shuffle.</param>
    /// <returns>A shuffled sequence containing the elements of <paramref name="this"/>.</returns>
    /// <remarks>
    /// This method uses the Fisher-Yates shuffle.
    /// For more information, see http://en.wikipedia.org/wiki/Fisher-Yates.
    /// </remarks>
    public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> @this)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");

        return ShuffleIterator(sources, new Random());
    }

    /// <summary>
    /// Enumerates the specified input sequence and returns a new sequence
    /// which contains all input elements in random order.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">The sequence to shuffle.</param>
    /// <param name="random">The random number generator used for shuffling.</param>
    /// <returns>A shuffled sequence containing the elements of <paramref name="this"/>.</returns>
    /// <remarks>
    /// This method uses the Fisher-Yates shuffle.
    /// For more information, see http://en.wikipedia.org/wiki/Fisher-Yates.
    /// </remarks>
    public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> @this, Random random)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");
        if (random == null) throw new ArgumentException($"{nameof(random)} must have value");

        return ShuffleIterator(sources, random);
    }

    private static IEnumerable<TSource> ShuffleIterator<TSource>(IEnumerable<TSource> @this, Random random)
    {
        var elements = @this.ToArray();

        for (var index = 0; index < elements.Length; index++)
        {
            var next = random.Next(index, elements.Length);

            yield return elements[next];

            elements[next] = elements[index];
        }
    }
}
