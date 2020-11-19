using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable u int 16.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an ushort?</returns>
    public static ushort? ToNullableUInt16(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (ushort?)null : Convert.ToUInt16(@this);
    }
}