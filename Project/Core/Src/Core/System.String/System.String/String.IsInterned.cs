public static partial class Extension
{
    /// <summary>
    ///     Retrieves a reference to a specified .
    /// </summary>
    /// <param name="this">The string to search for in the intern pool.</param>
    /// <returns>A reference to  if it is in the common language runtime intern pool; otherwise, null.</returns>
    public static string IsInterned(this string @this)
    {
        return string.IsInterned(@this);
    }
}