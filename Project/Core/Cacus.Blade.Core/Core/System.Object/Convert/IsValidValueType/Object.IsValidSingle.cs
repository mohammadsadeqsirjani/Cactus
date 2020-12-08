public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid float.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid float, false if not.</returns>
    public static bool IsValidSingle(this object @this)
    {
        return @this == null || float.TryParse(@this.ToString(), out _);
    }
}