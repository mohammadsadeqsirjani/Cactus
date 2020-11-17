using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable character.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a char?</returns>
    public static char? ToNullableChar(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (char?)null : Convert.ToChar(@this);
    }
}