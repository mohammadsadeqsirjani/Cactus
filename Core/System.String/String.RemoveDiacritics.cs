using System.Globalization;
using System.Linq;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that removes the diacritics character from the strings.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string without diacritics character.</returns>
    public static string RemoveDiacritics(this string @this)
    {
        var normalizedString = @this.Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder();

        foreach (var value in from value in normalizedString
                              let unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(value)
                              where unicodeCategory != UnicodeCategory.NonSpacingMark
                              select value)
            builder.Append(value);

        return builder.ToString().Normalize(NormalizationForm.FormC);
    }
}