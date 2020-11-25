public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a Unicode @this to its uppercase equivalent using the casing rules of the invariant
    ///     culture.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <returns>
    ///     The uppercase equivalent of the  parameter, or the unchanged value of , if  is already uppercase or not
    ///     alphabetic.
    /// </returns>
    public static char ToUpperInvariant(this char @this)
    {
        return char.ToUpperInvariant(@this);
    }
}