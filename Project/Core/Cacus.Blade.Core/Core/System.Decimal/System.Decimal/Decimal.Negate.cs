public static partial class Extension
{
    /// <summary>
    ///     Returns the result of multiplying the specified  value by negative one.
    /// </summary>
    /// <param name="this">The value to negate.</param>
    /// <returns>A decimal number with the value of , but the opposite sign.-or- Zero, if  is zero.</returns>
    public static decimal Negate(this decimal @this)
    {
        return decimal.Negate(@this);
    }
}