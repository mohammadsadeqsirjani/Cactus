public static partial class Extension
{
    /// <summary>
    ///     Divides two specified  values.
    /// </summary>
    /// <param name="this">The dividend.</param>
    /// <param name="value">The divisor.</param>
    /// <returns>The result of dividing  by .</returns>
    public static decimal Divide(this decimal @this, decimal value)
    {
        return decimal.Divide(@this, value);
    }
}