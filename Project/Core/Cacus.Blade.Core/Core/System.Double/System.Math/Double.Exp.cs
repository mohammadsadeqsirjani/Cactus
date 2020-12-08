using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns e raised to the specified power.
    /// </summary>
    /// <param name="this">A number specifying a power.</param>
    /// <returns>
    ///     The number e raised to the power . If  equals  or , that value is returned. If  equals , 0 is returned.
    /// </returns>
    public static double Exp(this double @this)
    {
        return Math.Exp(@this);
    }
}