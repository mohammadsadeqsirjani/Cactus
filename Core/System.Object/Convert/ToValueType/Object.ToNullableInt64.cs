using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable int 64.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a long?</returns>
    public static long? ToNullableInt64(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (long?)null : Convert.ToInt64(@this);
    }
}