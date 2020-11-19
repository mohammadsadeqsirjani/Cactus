public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a control @this.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a control @this; otherwise, false.</returns>
    public static bool IsControl(this char @this)
    {
        return char.IsControl(@this);
    }
}