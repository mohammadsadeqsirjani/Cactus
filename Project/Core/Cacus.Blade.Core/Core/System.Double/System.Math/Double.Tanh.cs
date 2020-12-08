using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the hyperbolic tangent of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>
    ///     The hyperbolic tangent of . If  is equal to , this method returns -1. If @this is equal to , this method
    ///     returns 1. If  is equal to , this method returns .
    /// </returns>
    public static double Tanh(this double @this)
    {
        return Math.Tanh(@this);
    }
}