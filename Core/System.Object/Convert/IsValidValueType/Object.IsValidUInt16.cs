public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid ushort.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid ushort, false if not.</returns>
    public static bool IsValidUInt16(this object @this)
    {
        return @this == null || ushort.TryParse(@this.ToString(), out _);
    }
}