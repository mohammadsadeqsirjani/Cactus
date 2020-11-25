using System;

public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that query if '@this' is morning.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if morning, false if not.</returns>
    public static bool IsMorning(this DateTimeOffset @this)
    {
        return @this.TimeOfDay < new DateTimeOffset(@this.Year, @this.Month, @this.Day, 12, 0, 0, @this.Offset).TimeOfDay;
    }
}