using System;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that replace first occurrence.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>The string with the first occurrence of old value replace by new value.</returns>
    public static string ReplaceFirst(this string @this, string oldValue, string newValue)
    {
        var startIndex = @this.IndexOf(oldValue, StringComparison.Ordinal);

        return startIndex == -1 ? @this : @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
    }

    /// <summary>
    ///     A string extension method that replace first number of occurrences.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="number">Number of.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>The string with the numbers of occurrences of old value replace by new value.</returns>
    public static string ReplaceFirst(this string @this, int number, string oldValue, string newValue)
    {
        var list = @this.Split(oldValue).ToList();
        var old = number + 1;
        var listStart = list.Take(old).ToList();
        var listEnd = list.Skip(old).ToList();

        return $"{string.Join(newValue, listStart)}{(listEnd.Any() ? oldValue : "")}{string.Join(oldValue, listEnd)}";
    }
}