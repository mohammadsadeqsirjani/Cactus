using System;

public static partial class Extension
{
    /// <summary>
    ///     A Double extension method that converts the @this to a money.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Double.</returns>
    public static double ToMoney(this double @this)
    {
        return Math.Round(@this, 2);
    }
}