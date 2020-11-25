using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the sine of the specified angle.
    /// </summary>
    /// <param name="this">An angle, measured in radians.</param>
    /// <returns>The sine of . If  is equal to , , or , this method returns .</returns>
    public static double Sin(this double @this)
    {
        return Math.Sin(@this);
    }
}