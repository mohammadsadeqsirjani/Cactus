using System.Collections.Generic;

public static partial class Extension
{
    /// <summary>
    ///     Concatenates all the elements of a string array, using the specified separator between each element.
    /// </summary>
    /// <param name="this">
    ///     The string to use as a separator.  is included in the returned string only if  has more
    ///     than one element.
    /// </param>
    /// <param name="value">An array that contains the elements to concatenate.</param>
    /// <returns>
    ///     A string that consists of the elements in  delimited by the  string. If  is an empty array, the method
    ///     returns .
    /// </returns>
    public static string Join(this string @this, string[] value)
    {
        return string.Join(@this, value);
    }

    /// <summary>
    ///     Concatenates the elements of an object array, using the specified separator between each element.
    /// </summary>
    /// <param name="this">
    ///     The string to use as a separator.  is included in the returned string only if  has more
    ///     than one element.
    /// </param>
    /// <param name="values">An array that contains the elements to concatenate.</param>
    /// <returns>
    ///     A string that consists of the elements of  delimited by the  string. If  is an empty array, the method
    ///     returns .
    /// </returns>
    public static string Join(this string @this, object[] values)
    {
        return string.Join(@this, values);
    }

    /// <summary>
    ///     A String extension method that joins.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">
    ///     The string to use as a separator.  is included in the returned string only if  has more
    ///     than one element.
    /// </param>
    /// <param name="values">An array that contains the elements to concatenate.</param>
    /// <returns>A String.</returns>
    public static string Join<T>(this string @this, IEnumerable<T> values)
    {
        return string.Join(@this, values);
    }

    /// <summary>
    ///     Concatenates all the elements of a string array, using the specified separator between each element.
    /// </summary>
    /// <param name="this">
    ///     The string to use as a separator.  is included in the returned string only if  has more
    ///     than one element.
    /// </param>
    /// <param name="values">An array that contains the elements to concatenate.</param>
    /// <returns>
    ///     A string that consists of the elements in  delimited by the  string. If  is an empty array, the method
    ///     returns .
    /// </returns>
    public static string Join(this string @this, IEnumerable<string> values)
    {
        return string.Join(@this, values);
    }

    /// <summary>
    ///     Concatenates the specified elements of a string array, using the specified separator between each element.
    /// </summary>
    /// <param name="this">
    ///     The string to use as a separator.  is included in the returned string only if  has more
    ///     than one element.
    /// </param>
    /// <param name="value">An array that contains the elements to concatenate.</param>
    /// <param name="startIndex">The first element in  to use.</param>
    /// <param name="count">The number of elements of  to use.</param>
    /// <returns>
    ///     A string that consists of the strings in  delimited by the  string. -or- if  is zero,  has no elements, or
    ///     and all the elements of  are .
    /// </returns>
    public static string Join(this string @this, string[] value, int startIndex, int count)
    {
        return string.Join(@this, value, startIndex, count);
    }
}