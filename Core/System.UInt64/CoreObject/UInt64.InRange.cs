public static partial class Extension
{
    /// <summary>
    ///     A T extension method that check if the value is between inclusively the minValue and maxValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minimum">The minimum value.</param>
    /// <param name="maximum">The maximum value.</param>
    public static bool InRange(this ulong @this, ulong minimum, ulong maximum)
    {
        return @this.CompareTo(minimum) >= 0 && @this.CompareTo(maximum) <= 0;
    }
}