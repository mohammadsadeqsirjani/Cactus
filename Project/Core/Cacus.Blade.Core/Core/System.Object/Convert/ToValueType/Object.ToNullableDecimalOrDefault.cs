using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable decimal or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a decimal?</returns>
    public static decimal? ToNullableDecimalOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (decimal?)null : Convert.ToDecimal(@this);
        }
        catch (Exception)
        {
            return default(decimal);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable decimal or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a decimal?</returns>
    public static decimal? ToNullableDecimalOrDefault(this object @this, decimal? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (decimal?)null : Convert.ToDecimal(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable decimal or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a decimal?</returns>
    public static decimal? ToNullableDecimalOrDefault(this object @this, Func<decimal?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (decimal?)null : Convert.ToDecimal(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}
