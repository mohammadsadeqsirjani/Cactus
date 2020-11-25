using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the natural (base e) logarithm of a specified number.
    /// </summary>
    /// <param name="this">The number whose logarithm is to be found.</param>
    /// <returns>
    ///     One of the values in the following table.  parameterReturn value Positive The natural logarithm of ; that is,
    ///     ln , or log eZero Negative Equal to Equal to.
    /// </returns>
    public static double Log(this double @this)
    {
        return Math.Log(@this);
    }

    /// <summary>
    ///     Returns the logarithm of a specified number in a specified base.
    /// </summary>
    /// <param name="this">The number whose logarithm is to be found.</param>
    /// <param name="base">The base of the logarithm.</param>
    /// <returns>
    ///     One of the values in the following table. (+Infinity denotes , -Infinity denotes , and NaN denotes .)Return
    ///     value&gt; 0(0 &lt;&lt; 1) -or-(&gt; 1)log base(a)&lt; 0(any value)NaN(any value)&lt; 0NaN != 1 = 0NaN != 1
    ///     = +InfinityNaN = NaN(any value)NaN(any value) = NaNNaN(any value) = 1NaN = 00 &lt;&lt; 1 +Infinity = 0&gt; 1-
    ///     Infinity =  +Infinity0 &lt;&lt; 1-Infinity =  +Infinity&gt; 1+Infinity = 1 = 00 = 1 = +Infinity0.
    /// </returns>
    /// ###
    public static double Log(this double @this, double @base)
    {
        return Math.Log(@this, @base);
    }
}