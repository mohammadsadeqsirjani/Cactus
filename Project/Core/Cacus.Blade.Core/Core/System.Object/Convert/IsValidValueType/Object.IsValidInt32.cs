public static partial class Extension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid int.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid int, false if not.</returns>
    public static bool IsValidInt32(this object @this)
    {
        return @this == null || int.TryParse(@this.ToString(), out _);
    }
}