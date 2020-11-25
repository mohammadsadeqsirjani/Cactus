using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable date time off set.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTimeOffset?</returns>
    public static DateTimeOffset? ToNullableDateTimeOffSet(this object @this)
    {
        return @this == null || @this == DBNull.Value
            ? (DateTimeOffset?)null
            : new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
    }
}