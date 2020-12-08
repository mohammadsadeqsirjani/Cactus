public static partial class Extension
{
    /// <summary>
    ///     Computes the remainder after dividing two  values.
    /// </summary>
    /// <param name="this">The dividend.</param>
    /// <param name="value">The divisor.</param>
    /// <returns>The remainder after dividing  by .</returns>
    public static decimal Remainder(this decimal @this, decimal value)
    {
        return decimal.Remainder(@this, value);
    }
}