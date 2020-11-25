public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the specified  object is a high surrogate.
    /// </summary>
    /// <param name="this">The Unicode @this to evaluate.</param>
    /// <returns>
    ///     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF; otherwise, false.
    /// </returns>
    public static bool IsHighSurrogate(this char @this)
    {
        return char.IsHighSurrogate(@this);
    }
}