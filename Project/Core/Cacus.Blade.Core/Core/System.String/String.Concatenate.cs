using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>An IEnumerable&lt;string&gt; extension method that concatenates the given this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string Concatenate(this IEnumerable<string> @this)
    {
        var builder = new StringBuilder();

        foreach (var str in @this) builder.Append(str);

        return builder.ToString();
    }

    /// <summary>An IEnumerable&lt;T&gt; extension method that concatenates.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="source">The source to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>A string.</returns>
    public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
    {
        var builder = new StringBuilder();

        foreach (var item in source) builder.Append(func(item));

        return builder.ToString();
    }
}