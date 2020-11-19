using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable boolean.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a bool?</returns>
    public static bool? ToNullableBoolean(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (bool?)null : Convert.ToBoolean(@this);
    }
}