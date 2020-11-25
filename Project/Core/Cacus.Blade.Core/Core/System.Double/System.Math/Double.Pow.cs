using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns a specified number raised to the specified power.
    /// </summary>
    /// <param name="this">A double-precision floating-point number to be raised to a power.</param>
    /// <param name="value">A double-precision floating-point number that specifies a power.</param>
    /// <returns>The number  raised to the power .</returns>
    public static double Pow(this double @this, double value)
    {
        return Math.Pow(@this, value);
    }
}