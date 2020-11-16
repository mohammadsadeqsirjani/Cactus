using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the hyperbolic cosine of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>The hyperbolic cosine of . If  is equal to  or ,  is returned. If  is equal to ,  is returned.</returns>
    public static double Cosh(this double @this)
    {
        return Math.Cosh(@this);
    }
}