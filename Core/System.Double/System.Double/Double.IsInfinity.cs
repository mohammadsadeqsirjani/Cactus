public static partial class Extension
{
    /// <summary>
    ///     Returns a value indicating whether the specified number evaluates to negative or positive infinity.
    /// </summary>
    /// <param name="this">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to  or ; otherwise, false.</returns>
    public static bool IsInfinity(this double @this)
    {
        return double.IsInfinity(@this);
    }
}