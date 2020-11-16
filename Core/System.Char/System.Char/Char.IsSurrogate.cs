public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified @this has a surrogate code unit.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is either a high surrogate or a low surrogate; otherwise, false.</returns>
    public static bool IsSurrogate(this char @this)
    {
        return char.IsSurrogate(@this);
    }
}