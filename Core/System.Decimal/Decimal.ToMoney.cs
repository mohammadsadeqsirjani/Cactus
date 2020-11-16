using System;

public static partial class Extension
{
    /// <summary>
    ///     A Decimal extension method that converts the @this to a money.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Decimal.</returns>
    public static decimal ToMoney(this decimal @this)
    {
        return Math.Round(@this, 2);
    }
}