using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static int FindIndex<T>(this T[] @this, Predicate<T> match)
    {
        return Array.FindIndex(@this, match);
    }

    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static int FindIndex<T>(this T[] @this, int startIndex, Predicate<T> match)
    {
        return Array.FindIndex(@this, startIndex, match);
    }

    /// <summary>
    ///     A T[] extension method that searches for the first index.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="count">Number of.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found index.</returns>
    public static int FindIndex<T>(this T[] @this, int startIndex, int count, Predicate<T> match)
    {
        return Array.FindIndex(@this, startIndex, count, match);
    }
}