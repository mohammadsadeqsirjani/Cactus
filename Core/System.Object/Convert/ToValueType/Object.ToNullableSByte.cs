using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable s byte.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a sbyte?</returns>
    public static sbyte? ToNullableSByte(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (sbyte?)null : Convert.ToSByte(@this);
    }
}