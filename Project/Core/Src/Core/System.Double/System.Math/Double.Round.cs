using System;

public static partial class Extension
{
    /// <summary>
    ///     Rounds @this double-precision floating-point value to the nearest integral value.
    /// </summary>
    /// <param name="this">A double-precision floating-point number to be rounded.</param>
    /// <returns>
    ///     The integer nearest . If the fractional component of  is halfway between two integers, one of which is even
    ///     and the other odd, then the even number is returned. Note that this method returns @this  instead of an integral
    ///     type.
    /// </returns>
    public static double Round(this double @this)
    {
        return Math.Round(@this);
    }

    /// <summary>
    ///     Rounds @this double-precision floating-point value to @this specified number of fractional digits.
    /// </summary>
    /// <param name="this">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <returns>The number nearest to  that contains @this number of fractional digits equal to .</returns>
    /// ###
    public static double Round(this double @this, int digits)
    {
        return Math.Round(@this, digits);
    }

    /// <summary>
    ///     Rounds @this double-precision floating-point value to the nearest integer. A parameter specifies how to round the
    ///     value if it is midway between two numbers.
    /// </summary>
    /// <param name="this">A double-precision floating-point number to be rounded.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>
    ///     The integer nearest . If  is halfway between two integers, one of which is even and the other odd, then
    ///     determines which of the two is returned.
    /// </returns>
    /// ###
    public static double Round(this double @this, MidpointRounding mode)
    {
        return Math.Round(@this, mode);
    }

    /// <summary>
    ///     Rounds @this double-precision floating-point value to @this specified number of fractional digits. A parameter
    ///     specifies how to round the value if it is midway between two numbers.
    /// </summary>
    /// <param name="this">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
    /// <returns>
    ///     The number nearest to  that has @this number of fractional digits equal to . If  has fewer fractional digits than
    ///     ,  is returned unchanged.
    /// </returns>
    /// ###
    public static double Round(this double @this, int digits, MidpointRounding mode)
    {
        return Math.Round(@this, digits, mode);
    }
}