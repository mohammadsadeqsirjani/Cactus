public static partial class Extension
{
    /// <summary>
    ///     Compares two specified  objects by evaluating the numeric values of the corresponding  objects in each string.
    /// </summary>
    /// <param name="this">The first string to compare.</param>
    /// <param name="value">The second string to compare.</param>
    /// <returns>
    ///     An integer that indicates the lexical relationship between the two commands.ValueCondition Less than zero
    ///     is less than . Zero  and  are equal. Greater than zero  is greater than .
    /// </returns>
    public static int CompareOrdinal(this string @this, string value)
    {
        return string.CompareOrdinal(@this, value);
    }

    /// <summary>
    ///     Compares substrings of two specified  objects by evaluating the numeric values of the corresponding  objects
    ///     in each substring.
    /// </summary>
    /// <param name="this">The first string to use in the comparison.</param>
    /// <param name="thisIndex">The starting index of the substring in .</param>
    /// <param name="value">The second string to use in the comparison.</param>
    /// <param name="valueIndex">The starting index of the substring in .</param>
    /// <param name="length">The maximum number of characters in the substrings to compare.</param>
    /// <returns>
    ///     A 32-bit signed integer that indicates the lexical relationship between the two commands.ValueCondition
    ///     Less than zero The substring in  is less than the substring in . Zero The substrings are equal, or  is zero.
    ///     Greater than zero The substring in  is greater than the substring in .
    /// </returns>
    public static int CompareOrdinal(this string @this, int thisIndex, string value, int valueIndex, int length)
    {
        return string.CompareOrdinal(@this, thisIndex, value, valueIndex, length);
    }
}