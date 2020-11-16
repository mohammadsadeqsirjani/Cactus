public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a lowercase letter.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a lowercase letter; otherwise, false.</returns>
    public static bool IsLower(this char @this)
    {
        return char.IsLower(@this);
    }
}