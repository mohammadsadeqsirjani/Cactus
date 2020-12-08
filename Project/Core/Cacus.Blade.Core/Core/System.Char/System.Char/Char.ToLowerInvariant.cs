public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a Unicode @this to its lowercase equivalent using the casing rules of the invariant
    ///     culture.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of the  parameter, or the unchanged value of , if  is already lowercase or not
    ///     alphabetic.
    /// </returns>
    public static char ToLowerInvariant(this char @this)
    {
        return char.ToLowerInvariant(@this);
    }
}