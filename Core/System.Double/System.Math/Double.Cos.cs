using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the cosine of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>The cosine of . If  is equal to , , or , this method returns .</returns>
    public static double Cos(this double @this)
    {
        return Math.Cos(@this);
    }
}