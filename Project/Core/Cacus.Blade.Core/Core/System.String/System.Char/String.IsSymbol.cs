public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a symbol
    ///     character.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a symbol character; otherwise, false.</returns>
    public static bool IsSymbol(this string @this, int index)
    {
        return char.IsSymbol(@this, index);
    }
}