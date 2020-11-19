public static partial class Extension
{
    /// <summary>
    ///     Returns a value indicating whether the specified number evaluates to positive infinity.
    /// </summary>
    /// <param name="this">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to ; otherwise, false.</returns>
    public static bool IsPositiveInfinity(this double @this)
    {
        return double.IsPositiveInfinity(@this);
    }
}