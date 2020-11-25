public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a Unicode letter.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a letter; otherwise, false.</returns>
    public static bool IsLetter(this char @this)
    {
        return char.IsLetter(@this);
    }
}