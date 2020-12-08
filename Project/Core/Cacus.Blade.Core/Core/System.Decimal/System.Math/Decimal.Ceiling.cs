public static partial class Extension
{
    /// <summary>
    ///     Returns the smallest integral value that is greater than or equal to the specified decimal number.
    /// </summary>
    /// <param name="this">A decimal number.</param>
    /// <returns>
    ///     The smallest integral value that is greater than or equal to . Note that this method returns a  instead of an
    ///     integral type.
    /// </returns>
    public static decimal Ceiling(this decimal @this)
    {
        return System.Math.Ceiling(@this);
    }
}