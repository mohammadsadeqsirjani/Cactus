using System.Globalization;

public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a specified Unicode @this to its lowercase equivalent using specified culture-
    ///     specific formatting information.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>
    ///     The lowercase equivalent of , modified according to , or the unchanged value of , if  is already lowercase or
    ///     not alphabetic.
    /// </returns>
    public static char ToLower(this char @this, CultureInfo culture)
    {
        return char.ToLower(@this, culture);
    }

    /// <summary>
    ///     Converts the value of a Unicode @this to its lowercase equivalent.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of , or the unchanged value of , if  is already lowercase or not alphabetic.
    /// </returns>
    public static char ToLower(this char @this)
    {
        return char.ToLower(@this);
    }
}