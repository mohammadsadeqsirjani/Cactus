public static partial class Extension
{
    /// <summary>
    ///     Returns a @this indicating the sign of a decimal number.
    /// </summary>
    /// <param name="this">A signed decimal number.</param>
    /// <returns>
    ///     A number that indicates the sign of , as shown in the following table.Return @this Meaning -1  is less than
    ///     zero. 0  is equal to zero. 1  is greater than zero.
    /// </returns>
    public static int Sign(this decimal @this)
    {
        return System.Math.Sign(@this);
    }
}