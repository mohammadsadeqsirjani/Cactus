public static partial class Extension
{
    /// <summary>
    ///     A T extension method that check if the value is between (exclusif) the minValue and maxValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minimum">The minimum value.</param>
    /// <param name="maximum">The maximum value.</param>
    /// <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
    /// ###
    public static bool Between(this System.DateTimeOffset @this, System.DateTimeOffset minimum,
        System.DateTimeOffset maximum)
    {
        return minimum.CompareTo(@this) == -1 && @this.CompareTo(maximum) == -1;
    }
}