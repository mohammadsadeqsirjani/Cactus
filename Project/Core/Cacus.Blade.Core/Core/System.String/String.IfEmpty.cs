public static partial class Extension
{
    /// <summary>
    ///     A string extension method that if empty.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A string.</returns>
    public static string IfEmpty(this string @this, string defaultValue)
    {
        return (@this.IsNotEmpty() ? @this : defaultValue);
    }
}