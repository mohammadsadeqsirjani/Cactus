using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a Guid?</returns>
    public static Guid? ToNullableGuidOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (Guid?)null : new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return Guid.Empty;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a Guid?</returns>
    public static Guid? ToNullableGuidOrDefault(this object @this, Guid? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (Guid?)null : new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a Guid?</returns>
    public static Guid? ToNullableGuidOrDefault(this object @this, Func<Guid?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (Guid?)null : new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}