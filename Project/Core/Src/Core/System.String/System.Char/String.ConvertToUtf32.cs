public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a
    ///     Unicode code point.
    /// </summary>
    /// <param name="this">A string that contains a character or surrogate pair.</param>
    /// <param name="index">The index position of the character or surrogate pair in .</param>
    /// <returns>
    ///     The 21-bit Unicode code point represented by the character or surrogate pair at the position in the parameter
    ///     specified by the  parameter.
    /// </returns>
    public static int ConvertToUtf32(this string @this, int index)
    {
        return char.ConvertToUtf32(@this, index);
    }
}
