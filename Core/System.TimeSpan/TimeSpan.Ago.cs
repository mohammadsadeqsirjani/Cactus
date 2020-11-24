using System;

public static partial class Extension
{
    /// <summary>
    ///     A TimeSpan extension method that subtract the specified TimeSpan to the current DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current DateTime with the specified TimeSpan subtracted from it.</returns>
    public static DateTime Ago(this TimeSpan @this)
    {
        return DateTime.Now.Subtract(@this);
    }

    /// <summary>
    /// Subtracts given <see cref="TimeSpan"/> from <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the past.
    /// </summary>
    public static DateTime Before(this TimeSpan @this, DateTime originalValue)
    {
        return originalValue - @this;
    }
}