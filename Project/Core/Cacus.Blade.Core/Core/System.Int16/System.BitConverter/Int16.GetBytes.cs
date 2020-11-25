using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the specified 16-bit signed integer @this as an array of bytes.
    /// </summary>
    /// <param name="this">The number to convert.</param>
    /// <returns>An array of bytes with length 2.</returns>
    public static byte[] GetBytes(this short @this)
    {
        return BitConverter.GetBytes(@this);
    }
}