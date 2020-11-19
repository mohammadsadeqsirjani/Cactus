public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as white space.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is white space; otherwise, false.</returns>
    public static bool IsWhiteSpace(this string @this, int index)
    {
        return char.IsWhiteSpace(@this, index);
    }
}
