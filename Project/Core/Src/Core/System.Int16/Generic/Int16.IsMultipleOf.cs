public static partial class Extension
{
    /// <summary>
    ///     An Int16 extension method that query if '@this' is multiple of.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factor">The factor.</param>
    /// <returns>true if multiple of, false if not.</returns>
    public static bool IsMultipleOf(this short @this, short factor)
    {
        return @this % factor == 0;
    }
}