public static partial class Extension
{
    /// <summary>
    ///     Returns a value indicating whether the specified number evaluates to negative infinity.
    /// </summary>
    /// <param name="this">A single-precision floating-point number.</param>
    /// <returns>true if  evaluates to ; otherwise, false.</returns>
    public static bool IsNegativeInfinity(this float @this)
    {
        return float.IsNegativeInfinity(@this);
    }
}