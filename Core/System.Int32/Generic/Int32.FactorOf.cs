public static partial class Extension
{
    /// <summary>
    ///     An Int32 extension method that factor of.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="number">The factor number.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool FactorOf(this int @this, int number)
    {
        return number % @this == 0;
    }
}