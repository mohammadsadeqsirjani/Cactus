using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable character or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a char?</returns>
    public static char? ToNullableCharOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (char?)null : Convert.ToChar(@this);
        }
        catch (Exception)
        {
            return default(char);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable character or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a char?</returns>
    public static char? ToNullableCharOrDefault(this object @this, char? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (char?)null : Convert.ToChar(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable character or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a char?</returns>
    public static char? ToNullableCharOrDefault(this object @this, Func<char?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (char?)null : Convert.ToChar(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}