using System;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that replace last occurrence.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>The string with the last occurrence of old value replace by new value.</returns>
    public static string ReplaceLast(this string @this, string oldValue, string newValue)
    {
        var startIndex = @this.LastIndexOf(oldValue, StringComparison.Ordinal);

        return startIndex == -1 ? @this : @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
    }

    /// <summary>
    ///     A string extension method that replace last numbers occurrences.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="number">Number of.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>The string with the last numbers occurrences of old value replace by new value.</returns>
    public static string ReplaceLast(this string @this, int number, string oldValue, string newValue)
    {
        var list = @this.Split(oldValue).ToList();
        var old = Math.Max(0, list.Count - number - 1);
        var listStart = list.Take(old);
        var listEnd = list.Skip(old);

        return $"{string.Join(oldValue, listStart)}{(old > 0 ? oldValue : "")}{string.Join(newValue, listEnd)}";
    }
}