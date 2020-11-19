public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a punctuation mark.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a punctuation mark; otherwise, false.</returns>
    public static bool IsPunctuation(this char @this)
    {
        return char.IsPunctuation(@this);
    }
}