using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable u int 64.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an ulong?</returns>
    public static ulong? ToNullableUInt64(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (ulong?)null : Convert.ToUInt64(@this);
    }
}