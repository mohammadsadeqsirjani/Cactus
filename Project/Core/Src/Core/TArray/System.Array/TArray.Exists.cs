using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that exists.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool Exists<T>(this T[] @this, Predicate<T> match)
    {
        return Array.Exists(@this, match);
    }
}