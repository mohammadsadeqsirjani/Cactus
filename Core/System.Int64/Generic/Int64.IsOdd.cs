public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that query if '@this' is odd.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if odd, false if not.</returns>
    public static bool IsOdd(this long @this)
    {
        return @this % 2 != 0;
    }
}