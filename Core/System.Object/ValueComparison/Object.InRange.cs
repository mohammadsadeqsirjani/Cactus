using System;

public static partial class Extension
{
    /// <summary>
    ///     A T extension method that check if the value is between inclusively the minimum and maximum.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minimum">The minimum value.</param>
    /// <param name="maximum">The maximum value.</param>
    /// <returns>true if the value is between inclusively the minimum and maximum, otherwise false.</returns>
    public static bool InRange<T>(this T @this, T minimum, T maximum) where T : IComparable<T>
    {
        return @this.CompareTo(minimum) >= 0 && @this.CompareTo(maximum) <= 0;
    }
}