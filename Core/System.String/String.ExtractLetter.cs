using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that extracts the letter described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted letter.</returns>
    public static string ExtractLetter(this string @this)
    {
        return new string(@this.ToCharArray().Where(char.IsLetter).ToArray());
    }
}