using System;
using System.ComponentModel;

public static partial class Extension
{
    /// <summary>
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <returns>A T.</returns>

    public static T To<T>(this object @this)
    {
        if (@this == null) return default;

        var targetType = typeof(T);

        if (@this.GetType() == targetType) return (T)@this;

        var converter = TypeDescriptor.GetConverter(@this);

        if (converter.CanConvertTo(targetType)) return (T)converter.ConvertTo(@this, targetType);

        converter = TypeDescriptor.GetConverter(targetType);

        if (converter.CanConvertFrom(@this.GetType())) return (T)converter.ConvertFrom(@this);

        if (@this == DBNull.Value) return (T)(object)null;

        return (T)@this;
    }

    /// <summary>
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <param name="this">this.</param>
    /// <param name="type">The type.</param>
    /// <returns>An object.</returns>
    public static object To(this object @this, Type type)
    {
        if (@this == null) return @this;

        var targetType = type;

        if (@this.GetType() == targetType) return @this;

        var converter = TypeDescriptor.GetConverter(@this);

        if (converter.CanConvertTo(targetType)) return converter.ConvertTo(@this, targetType);

        converter = TypeDescriptor.GetConverter(targetType);

        if (converter.CanConvertFrom(@this.GetType())) return converter.ConvertFrom(@this);

        return @this == DBNull.Value ? null : @this;
    }
}