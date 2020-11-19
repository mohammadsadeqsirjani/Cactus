public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified Unicode @this is categorized as a decimal digit.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>true if  is a decimal digit; otherwise, false.</returns>
    public static bool IsDigit(this char @this)
    {
        return char.IsDigit(@this);
    }
}