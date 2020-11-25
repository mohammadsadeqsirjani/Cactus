using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable float.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a float?</returns>
    public static float? ToNullableSingle(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (float?)null : Convert.ToSingle(@this);
    }
}