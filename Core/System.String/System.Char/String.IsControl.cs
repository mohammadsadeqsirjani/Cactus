public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a control
    ///     character.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a control character; otherwise, false.</returns>
    public static bool IsControl(this string @this, int index)
    {
        return char.IsControl(@this, index);
    }
}