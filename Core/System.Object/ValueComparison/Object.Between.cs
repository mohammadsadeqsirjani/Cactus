using System;

public static partial class Extension
{
    /// <summary>
    ///     A T extension method that check if the value is between (exclusive) the minimum and maximum.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minimum">The minimum value.</param>
    /// <param name="maximum">The maximum value.</param>
    /// <returns>true if the value is between the minimum and maximum, otherwise false.</returns>
    public static bool Between<T>(this T @this, T minimum, T maximum) where T : IComparable<T>
    {
        return minimum.CompareTo(@this) == -1 && @this.CompareTo(maximum) == -1;
    }
}