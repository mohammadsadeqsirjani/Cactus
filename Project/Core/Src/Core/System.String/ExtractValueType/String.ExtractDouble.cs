using System;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that extracts the Double from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted Double.</returns>
    public static double ExtractDouble(this string @this)
    {
        var builder = new StringBuilder();

        for (var i = 0; i < @this.Length; i++)
        {
            if (!char.IsDigit(@this[i]) && @this[i] != '.') continue;

            if (builder.Length == 0 && i > 0 && @this[i - 1] == '-') builder.Append('-');

            builder.Append(@this[i]);
        }

        return Convert.ToDouble(builder.ToString());
    }
}