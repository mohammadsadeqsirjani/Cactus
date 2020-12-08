public static partial class Extension
{
    /// <summary>
    ///     Returns a value that indicates whether the specified value is not a number ().
    /// </summary>
    /// <param name="this">A double-precision floating-point number.</param>
    /// <returns>true if  evaluates to ; otherwise, false.</returns>
    public static bool IsNaN(this double @this)
    {
        return double.IsNaN(@this);
    }
}