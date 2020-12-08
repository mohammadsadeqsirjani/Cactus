using System;

public static partial class Extension
{
    /// <summary>
    ///     A bool extension method that convert this object into a binary representation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A binary representation of this object.</returns>
    public static byte ToBinary(this bool @this)
    {
        return Convert.ToByte(@this);
    }
}