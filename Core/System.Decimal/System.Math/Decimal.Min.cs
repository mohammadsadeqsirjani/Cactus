public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two decimal numbers.
    /// </summary>
    /// <param name="this">The first of two decimal numbers to compare.</param>
    /// <param name="value">The second of two decimal numbers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller.</returns>
    public static decimal Min(this decimal @this, decimal value)
    {
        return System.Math.Min(@this, value);
    }
}