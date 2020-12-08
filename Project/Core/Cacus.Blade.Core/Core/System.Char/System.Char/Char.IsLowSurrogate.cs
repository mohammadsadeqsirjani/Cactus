public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified  object is a low surrogate.
    /// </summary>
    /// <param name="this">The @this to evaluate.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+DC00 through U+DFFF; otherwise, false.
    /// </returns>
    public static bool IsLowSurrogate(this char @this)
    {
        return char.IsLowSurrogate(@this);
    }
}