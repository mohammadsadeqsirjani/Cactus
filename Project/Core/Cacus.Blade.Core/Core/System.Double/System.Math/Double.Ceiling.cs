using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the smallest integral value that is greater than or equal to the specified double-precision floating-
    ///     point number.
    /// </summary>
    /// <param name="this">A double-precision floating-point number.</param>
    /// <returns>
    ///     The smallest integral value that is greater than or equal to . If  is equal to , , or , that value is
    ///     returned. Note that this method returns @this  instead of an integral type.
    /// </returns>
    public static double Ceiling(this double @this)
    {
        return Math.Ceiling(@this);
    }
}