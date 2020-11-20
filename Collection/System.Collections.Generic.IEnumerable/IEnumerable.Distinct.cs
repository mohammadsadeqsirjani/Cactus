using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    /// Returns distinct elements from the given sequence using the default equality comparer
    /// to compare values projected by <paramref name="projection"/>.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <typeparam name="TResult">The type of the projected value for each element of the sequence.</typeparam>
    /// <param name="this">The sequence.</param>
    /// <param name="projection">The projection that is applied to each element to retrieve the value which is being compared.</param>
    /// <returns>A sequence of elements whose projected values are distinct.</returns>
    public static IEnumerable<TSource> Distinct<TSource, TResult>(this IEnumerable<TSource> @this,
        Func<TSource, TResult> projection)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");
        if (projection == null) throw new ArgumentException($"{nameof(projection)} is null. Function must have value.");

        return DistinctIterator(sources, projection, EqualityComparer<TResult>.Default);
    }

    /// <summary>
    /// Returns distinct elements from the given sequence using the specified equality comparer
    /// to compare values projected by <paramref name="projection"/>.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="this"/>.</typeparam>
    /// <typeparam name="TResult">The type of the projected value for each element of the sequence.</typeparam>
    /// <param name="this">The sequence.</param>
    /// <param name="projection">The projection that is applied to each element to retrieve the value which is being compared.</param>
    /// <param name="equalityComparer">The equality comparer to use for comparing the projected values.</param>
    /// <returns>A sequence of elements whose projected values are considered distinct by the specified equality comparer.</returns>
    public static IEnumerable<TSource> Distinct<TSource, TResult>(this IEnumerable<TSource> @this,
        Func<TSource, TResult> projection, IEqualityComparer<TResult> equalityComparer)
    {
        var sources = @this.ToList();

        if (sources.IsNullOrEmpty()) throw new ArgumentException($"{nameof(sources)} is null or empty");
        if (projection == null) throw new ArgumentException($"{nameof(projection)} is null. Function must have value.");
        if (equalityComparer == null)
            throw new ArgumentException($"{nameof(equalityComparer)} is null. Function must have value.");

        return DistinctIterator(sources, projection, equalityComparer);
    }

    private static IEnumerable<TSource> DistinctIterator<TSource, TResult>(IEnumerable<TSource> @this,
        Func<TSource, TResult> projection, IEqualityComparer<TResult> equalityComparer)
    {
        var alreadySeenValues = new HashSet<TResult>(equalityComparer);

        foreach (var element in @this)
        {
            var value = projection(element);

            if (alreadySeenValues.Contains(value)) continue;

            yield return element;
            alreadySeenValues.Add(value);
        }
    }
}