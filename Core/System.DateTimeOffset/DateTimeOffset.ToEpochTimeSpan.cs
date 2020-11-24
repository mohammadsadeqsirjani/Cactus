using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that converts the @this to an epoch time span.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a TimeSpan.</returns>
    public static TimeSpan ToEpochTimeSpan(this DateTimeOffset @this)
    {
        return @this.Subtract(new DateTimeOffset(1970, 1, 1, 0, 0, 0, @this.Offset));
    }
}
