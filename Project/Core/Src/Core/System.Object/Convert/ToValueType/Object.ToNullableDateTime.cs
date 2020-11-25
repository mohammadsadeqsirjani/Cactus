using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable date time.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTime?</returns>
    public static DateTime? ToNullableDateTime(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(@this);
    }
}
