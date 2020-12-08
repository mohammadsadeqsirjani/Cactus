public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a separator @this.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a separator @this; otherwise, false.</returns>
    public static bool IsSeparator(this char @this)
    {
        return char.IsSeparator(@this);
    }
}