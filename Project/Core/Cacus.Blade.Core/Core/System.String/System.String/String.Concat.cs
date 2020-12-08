using System.Collections.Generic;

public static partial class Extension
{
    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="this">The first string to concatenate.</param>
    /// <param name="values">The string array</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static string Concat<T>(this string @this, params object[] values)
    {
        return string.Concat(@this, values);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="this">The first string to concatenate.</param>
    /// <param name="values">The string array</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static string Concat(this string @this, params string[] values)
    {
        return string.Concat(@this, values);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="this">The first string to concatenate.</param>
    /// <param name="values">The string array</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static string Concat(this string @this, IEnumerable<string> values)
    {
        return string.Concat(@this, values);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="this">The first string to concatenate.</param>
    /// <param name="values">The string array</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static string Concat<T>(this string @this, IEnumerable<T> values)
    {
        return string.Concat(@this, values);
    }
}