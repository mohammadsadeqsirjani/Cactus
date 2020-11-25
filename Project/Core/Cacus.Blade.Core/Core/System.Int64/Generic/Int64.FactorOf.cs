public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that factor of.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="number">The factor number.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool FactorOf(this long @this, long number)
    {
        return number % @this == 0;
    }
}