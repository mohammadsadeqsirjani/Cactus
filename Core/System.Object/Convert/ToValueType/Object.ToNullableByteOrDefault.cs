using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a byte?</returns>
    public static byte? ToNullableByteOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (byte?)null : Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return default(byte);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a byte?</returns>
    public static byte? ToNullableByteOrDefault(this object @this, byte? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (byte?)null : Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a byte?</returns>
    public static byte? ToNullableByteOrDefault(this object @this, Func<byte?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (byte?)null : Convert.ToByte(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}