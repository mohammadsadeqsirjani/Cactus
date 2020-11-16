using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the tangent of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>The tangent of . If  is equal to , , or , this method returns .</returns>
    public static double Tan(this double @this)
    {
        return Math.Tan(@this);
    }
}