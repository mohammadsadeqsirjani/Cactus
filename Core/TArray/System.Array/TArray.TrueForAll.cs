using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that true for all.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool TrueForAll<T>(this T[] @this, Predicate<T> match)
    {
        return Array.TrueForAll(@this, match);
    }
}