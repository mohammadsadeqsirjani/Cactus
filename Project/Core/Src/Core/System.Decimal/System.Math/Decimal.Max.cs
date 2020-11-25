public static partial class Extension
{
    /// <summary>
    ///     Returns the larger of two decimal numbers.
    /// </summary>
    /// <param name="this">The first of two decimal numbers to compare.</param>
    /// <param name="value">The second of two decimal numbers to compare.</param>
    /// <returns>Parameter  or , whichever is larger.</returns>
    public static decimal Max(this decimal @this, decimal value)
    {
        return System.Math.Max(@this, value);
    }
}