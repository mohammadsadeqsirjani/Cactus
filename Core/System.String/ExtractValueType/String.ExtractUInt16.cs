using System;
using System.Linq;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that extracts the UInt16 from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted UInt16.</returns>
    public static ushort ExtractUInt16(this string @this)
    {
        var builder = new StringBuilder();

        foreach (var str in @this.Where(char.IsDigit)) builder.Append(str);

        return Convert.ToUInt16(builder.ToString());
    }
}