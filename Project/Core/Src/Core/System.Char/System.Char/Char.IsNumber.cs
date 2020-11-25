public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a number.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a number; otherwise, false.</returns>
    public static bool IsNumber(this char @this)
    {
        return char.IsNumber(@this);
    }
}