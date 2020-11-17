using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable unique identifier.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Guid?</returns>
    public static Guid? ToNullableGuid(this object @this)
    {
        return @this == null || @this == DBNull.Value ? (Guid?)null : new Guid(@this.ToString());
    }
}