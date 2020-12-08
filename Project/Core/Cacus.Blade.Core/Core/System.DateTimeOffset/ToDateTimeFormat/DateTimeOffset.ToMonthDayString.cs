using System.Globalization;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeSet extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this System.DateTimeOffset @this)
    {
        return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTimeSet extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this System.DateTimeOffset @this, string culture)
    {
        return @this.ToString("m", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTimeSet extension method that converts this object to a month day string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToMonthDayString(this System.DateTimeOffset @this, CultureInfo culture)
    {
        return @this.ToString("m", culture);
    }
}