public static partial class Extension
{
    /// <summary>
    ///     Returns a value that indicates whether the specified value is not a number ().
    /// </summary>
    /// <param name="this">A single-precision floating-point number.</param>
    /// <returns>true if  evaluates to not a number (); otherwise, false.</returns>
    public static bool IsNaN(this float @this)
    {
        return float.IsNaN(@this);
    }
}