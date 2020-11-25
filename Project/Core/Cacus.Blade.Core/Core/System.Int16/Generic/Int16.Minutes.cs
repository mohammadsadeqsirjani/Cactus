using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int16 extension method that minutes the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Minutes(this short @this)
    {
        return TimeSpan.FromMinutes(@this);
    }
}