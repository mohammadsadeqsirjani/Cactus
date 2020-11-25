public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid uint.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid uint, false if not.</returns>
    public static bool IsValidUInt32(this object @this)
    {
        return @this == null || uint.TryParse(@this.ToString(), out _);
    }
}