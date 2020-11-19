public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string has a surrogate code unit.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>
    ///     true if the character at position  in  is a either a high surrogate or a low surrogate; otherwise, false.
    /// </returns>
    public static bool IsSurrogate(this string @this, int index)
    {
        return char.IsSurrogate(@this, index);
    }
}
