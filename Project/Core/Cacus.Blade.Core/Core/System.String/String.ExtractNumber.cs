using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that extracts the number described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted number.</returns>
    public static string ExtractNumber(this string @this)
    {
        return new string(@this.ToCharArray().Where(char.IsNumber).ToArray());
    }
}