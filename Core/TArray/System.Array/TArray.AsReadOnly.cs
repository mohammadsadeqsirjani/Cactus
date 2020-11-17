using System;
using System.Collections.ObjectModel;
public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that converts an array to a read only.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <returns>A list of.</returns>
    public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] @this)
    {
        return Array.AsReadOnly(@this);
    }
}