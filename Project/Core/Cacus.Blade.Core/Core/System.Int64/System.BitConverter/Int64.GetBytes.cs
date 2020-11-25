using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the specified 64-bit signed integer this as an array of bytes.
    /// </summary>
    /// <param name="this">The number to convert.</param>
    /// <returns>An array of bytes with length 8.</returns>
    public static byte[] GetBytes(this long @this)
    {
        return BitConverter.GetBytes(@this);
    }
}
