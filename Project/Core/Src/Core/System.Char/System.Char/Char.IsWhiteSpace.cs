public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as white space.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is white space; otherwise, false.</returns>
    public static bool IsWhiteSpace(this char @this)
    {
        return char.IsWhiteSpace(@this);
    }
}