public static partial class Extension
{
    /// <summary>
    ///     Converts the specified Unicode @this to its equivalent string representation.
    /// </summary>
    /// <param name="this">The Unicode @this to convert.</param>
    /// <returns>The string representation of the value of .</returns>
    public static string ToString(this char @this)
    {
        return char.ToString(@this);
    }
}