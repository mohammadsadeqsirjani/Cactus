public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the  object at the specified position in a string is a low surrogate.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>
    ///     true if the numeric value of the specified character in the  parameter ranges from U+DC00 through U+DFFF;
    ///     otherwise, false.
    /// </returns>
    public static bool IsLowSurrogate(this string @this, int index)
    {
        return char.IsLowSurrogate(@this, index);
    }
}