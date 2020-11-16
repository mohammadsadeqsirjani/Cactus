using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that query if '@this' is prime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if prime, false if not.</returns>
    public static bool IsPrime(this long @this)
    {
        if (@this <= 1) return false;

        if (@this == 2) return true;

        if (@this % 2 == 0) return false;

        var sqrt = (long)Math.Sqrt(@this);

        for (var i = 3; i <= sqrt; i += 2)
            if (@this % i == 0) return false;

        return true;
    }
}