public static partial class Extension
{
    /// <summary>
    ///     Calculates the integral part of a specified decimal number.
    /// </summary>
    /// <param name="this">A number to truncate.</param>
    /// <returns>
    ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded.
    /// </returns>
    public static decimal Truncate(this decimal @this)
    {
        return System.Math.Truncate(@this);
    }
}