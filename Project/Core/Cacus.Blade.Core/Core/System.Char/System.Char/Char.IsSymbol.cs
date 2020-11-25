public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a symbol @this.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a symbol @this; otherwise, false.</returns>
    public static bool IsSymbol(this char @this)
    {
        return char.IsSymbol(@this);
    }
}