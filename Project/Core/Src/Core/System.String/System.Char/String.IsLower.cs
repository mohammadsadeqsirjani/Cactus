public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a lowercase
    ///     letter.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a lowercase letter; otherwise, false.</returns>
    public static bool IsLower(this string @this, int index)
    {
        return char.IsLower(@this, index);
    }
}