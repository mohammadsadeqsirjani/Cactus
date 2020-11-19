public static partial class Extension
{
    /// <summary>
    ///     Creates a new instance of  with the same value as a specified .
    /// </summary>
    /// <param name="this">The string to copy.</param>
    /// <returns>A new string with the same value as .</returns>
    public static string Copy(this string @this)
    {
        return string.Copy(@this);
    }
}
