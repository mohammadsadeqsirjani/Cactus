using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that searches for the first last.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="match">Specifies the match.</param>
    /// <returns>The found last.</returns>
    public static T FindLast<T>(this T[] @this, Predicate<T> match)
    {
        return Array.FindLast(@this, match);
    }
}