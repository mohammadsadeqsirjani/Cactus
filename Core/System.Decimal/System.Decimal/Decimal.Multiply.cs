public static partial class Extension
{
    /// <summary>
    ///     Multiplies two specified  values.
    /// </summary>
    /// <param name="this">The multiplicand.</param>
    /// <param name="value">The multiplier.</param>
    /// <returns>The result of multiplying  and .</returns>
    public static decimal Multiply(this decimal @this, decimal value)
    {
        return decimal.Multiply(@this, value);
    }
}