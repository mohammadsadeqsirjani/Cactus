using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that seconds the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Seconds(this long @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}