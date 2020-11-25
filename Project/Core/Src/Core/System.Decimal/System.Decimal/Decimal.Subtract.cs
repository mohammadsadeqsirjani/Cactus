public static partial class Extension
{
    /// <summary>
    ///     Subtracts one specified  value from another.
    /// </summary>
    /// <param name="this">The minuend.</param>
    /// <param name="value">The subtrahend.</param>
    /// <returns>The result of subtracting  from .</returns>
    public static decimal Subtract(this decimal @this, decimal value)
    {
        return decimal.Subtract(@this, value);
    }
}