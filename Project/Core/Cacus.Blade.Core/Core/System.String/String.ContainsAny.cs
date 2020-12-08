using System;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that query if '@this' contains any values.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains any values, otherwise false.</returns>
    public static bool ContainsAny(this string @this, params string[] values)
    {
        return values.Any(value => @this.IndexOf(value, StringComparison.Ordinal) != -1);
    }

    /// <summary>
    ///     A string extension method that query if '@this' contains any values.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains any values, otherwise false.</returns>
    public static bool ContainsAny(this string @this, StringComparison comparisonType, params string[] values)
    {
        return values.Any(value => @this.IndexOf(value, comparisonType) != -1);
    }
}