using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable int 32.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an int?</returns>
    public static int? ToNullableInt32(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (int?)null : Convert.ToInt32(@this);
    }
}