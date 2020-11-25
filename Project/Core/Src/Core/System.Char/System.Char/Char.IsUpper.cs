public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as an uppercase letter.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is an uppercase letter; otherwise, false.</returns>
    public static bool IsUpper(this char @this)
    {
        return char.IsUpper(@this);
    }
}