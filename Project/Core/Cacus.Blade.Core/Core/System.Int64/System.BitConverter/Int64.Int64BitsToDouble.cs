using System;

public static partial class Extension
{
    /// <summary>
    ///     Converts the specified 64-bit signed integer to a double-precision floating point number.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A double-precision floating point number whose value is equivalent to .</returns>
    public static double Int64BitsToDouble(this long value)
    {
        return BitConverter.Int64BitsToDouble(value);
    }
}