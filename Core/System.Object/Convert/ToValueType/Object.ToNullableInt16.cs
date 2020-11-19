using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable int 16.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a short?</returns>
    public static short? ToNullableInt16(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (short?)null : Convert.ToInt16(@this);
    }
}
