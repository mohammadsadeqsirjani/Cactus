using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a sbyte?</returns>
    public static sbyte? ToNullableSByteOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (sbyte?)null : Convert.ToSByte(@this);
        }
        catch (Exception)
        {
            return default(sbyte);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a sbyte?</returns>
    public static sbyte? ToNullableSByteOrDefault(this object @this, sbyte? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (sbyte?)null : Convert.ToSByte(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a sbyte?</returns>
    public static sbyte? ToNullableSByteOrDefault(this object @this, Func<sbyte?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (sbyte?)null : Convert.ToSByte(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}