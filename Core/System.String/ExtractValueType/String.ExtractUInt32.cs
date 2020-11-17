using System;
using System.Linq;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that extracts the UInt32 from the string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted UInt32.</returns>
    public static uint ExtractUInt32(this string @this)
    {
        var builder = new StringBuilder();

        foreach (var str in @this.Where(char.IsDigit)) builder.Append(str);

        return Convert.ToUInt32(builder.ToString());
    }
}