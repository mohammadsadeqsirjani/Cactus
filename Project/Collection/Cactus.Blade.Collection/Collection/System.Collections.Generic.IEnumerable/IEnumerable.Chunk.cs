using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Splits the given sequence into chunks of the given size.
    /// If the sequence length isn't evenly divisible by the chunk size,
    /// the last chunk will contain all remaining elements.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <param name="this">The sequence.</param>
    /// <param name="chunkSize">The number of elements per chunk.</param>
    /// <returns>The chunked sequence.</returns>
    public static IEnumerable<TSource[]> Chunk<TSource>(this IEnumerable<TSource> @this, int chunkSize)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(@this)} is null or empty");
        if (chunkSize <= 0) throw new ArgumentException($"{nameof(chunkSize)} must be positive");

        return ChunkIterator(sources, chunkSize);
    }

    private static IEnumerable<TSource[]> ChunkIterator<TSource>(IEnumerable<TSource> @this, int chunkSize)
    {
        TSource[] currentChunk = null;
        var currentIndex = 0;

        foreach (var element in @this)
        {
            currentChunk ??= new TSource[chunkSize];
            currentChunk[currentIndex++] = element;

            if (currentIndex != chunkSize) continue;

            yield return currentChunk;

            currentIndex = 0;
            currentChunk = null;
        }

        if (currentChunk == null) yield break;

        var lastChunk = new TSource[currentIndex];

        Array.Copy(currentChunk, lastChunk, currentIndex);

        yield return lastChunk;
    }
}