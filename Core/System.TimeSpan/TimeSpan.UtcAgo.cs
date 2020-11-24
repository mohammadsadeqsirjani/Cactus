using System;

public static partial class Extension
{
    /// <summary>
    ///     A TimeSpan extension method that subtract the specified TimeSpan to the current UTC (Coordinated Universal
    ///     Time)
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan subtracted from it.</returns>
    public static DateTime UtcAgo(this TimeSpan @this)
    {
        return DateTime.UtcNow.Subtract(@this);
    }

    /// <summary>
    ///     A TimeSpan extension method that subtract the specified TimeSpan to the current UTC (Coordinated Universal
    ///     Time)
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan subtracted from it.</returns>
    public static DateTimeOffset UtcAgoOffset(this TimeSpan @this)
    {
        return DateTimeOffset.UtcNow.Subtract(@this);
    }
}