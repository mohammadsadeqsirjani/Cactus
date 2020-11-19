using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable decimal.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a decimal?</returns>
    public static decimal? ToNullableDecimal(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (decimal?)null : Convert.ToDecimal(@this);
    }
}