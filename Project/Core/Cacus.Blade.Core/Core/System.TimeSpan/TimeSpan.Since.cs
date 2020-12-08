using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A TimeSpan extension method that add the specified TimeSpan to the current DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current DateTime with the specified TimeSpan added to it.</returns>
    public static DateTime Since(this TimeSpan @this)
    {
        return DateTime.Now.Add(@this);
    }

    /// <summary>
    ///     A TimeSpan extension method that add the specified TimeSpan to the current DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The current DateTimeOffset with the specified TimeSpan added to it.</returns>
    public static DateTimeOffset SinceOffset(this TimeSpan @this)
    {
        return DateTimeOffset.Now.Add(@this);
    }

    /// <summary>
    /// Adds given <see cref="TimeSpan"/> to supplied <paramref name="originalValue"/> <see cref="DateTime"/> and returns resulting <see cref="DateTime"/> in the future.
    /// </summary>
    public static DateTime Since(this TimeSpan @this, DateTime originalValue)
    {
        return originalValue + @this;
    }

    /// <summary>
    /// Adds given <see cref="TimeSpan"/> to supplied <paramref name="originalValue"/> <see cref="DateTimeOffset"/> and returns resulting <see cref="DateTimeOffset"/> in the future.
    /// </summary>
    public static DateTimeOffset SinceOffset(this TimeSpan @this, DateTimeOffset originalValue)
    {
        return originalValue + @this;
    }
}
