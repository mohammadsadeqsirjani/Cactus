using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable byte.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a byte?</returns>
    public static byte? ToNullableByte(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (byte?)null : Convert.ToByte(@this);
    }
}