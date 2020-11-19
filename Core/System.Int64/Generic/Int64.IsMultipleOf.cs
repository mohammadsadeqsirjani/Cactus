public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that query if '@this' is multiple of.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factor">The factor.</param>
    /// <returns>true if multiple of, false if not.</returns>
    public static bool IsMultipleOf(this long @this, long factor)
    {
        return @this % factor == 0;
    }
}