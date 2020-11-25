using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that searches for the first match.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>A T.</returns>
    public static T Find<T>(this T[] @this, Predicate<T> match)
    {
        return Array.Find(@this, match);
    }
}