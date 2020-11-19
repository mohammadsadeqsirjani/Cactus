public static partial class Extension
{
    /// <summary>
    ///     Returns the absolute @this of a  number.
    /// </summary>
    /// <param name="this">A number that is greater than or equal to , but less than or equal to .</param>
    /// <returns>A decimal number, x, such that 0 ? x ?.</returns>
    public static decimal Abs(this decimal @this)
    {
        return System.Math.Abs(@this);
    }
}