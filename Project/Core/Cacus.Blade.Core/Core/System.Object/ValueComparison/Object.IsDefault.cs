public static partial class Extension
{
    /// <summary>
    ///     A T extension method that query if 'this' is the default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The this to act on.</param>
    /// <returns>true if default, false if not.</returns>
    public static bool IsDefault<T>(this T @this
    )
    {
        return @this.Equals(default(T));
    }
}