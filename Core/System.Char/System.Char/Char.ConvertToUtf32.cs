public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
    /// </summary>
    /// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
    /// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
    /// <returns>The 21-bit Unicode code point represented by the  and  parameters.</returns>
    public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
    {
        return char.ConvertToUtf32(highSurrogate, lowSurrogate);
    }
}