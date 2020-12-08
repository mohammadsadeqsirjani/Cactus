using System;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that applies an operation to all items in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The array to act on.</param>
    /// <param name="action">The action.</param>
    public static void ForEach<T>(this T[] @this, Action<T> action)
    {
        Array.ForEach(@this, action);
    }
}