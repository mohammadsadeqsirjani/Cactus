using System;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that query if '@this' contains all values.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    public static bool ContainsAll(this string @this, params string[] values)
    {
        return values.All(value => @this.IndexOf(value, StringComparison.Ordinal) != -1);
    }

    /// <summary>
    ///     A string extension method that query if this object contains the given @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="comparisonType">Type of the comparison.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it contains all values, otherwise false.</returns>
    public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
    {
        return values.All(value => @this.IndexOf(value, comparisonType) != -1);
    }
}