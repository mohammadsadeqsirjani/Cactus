using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the hyperbolic sine of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>The hyperbolic sine of . If  is equal to , , or , this method returns a  equal to .</returns>
    public static double Sinh(this double @this)
    {
        return Math.Sinh(@this);
    }
}