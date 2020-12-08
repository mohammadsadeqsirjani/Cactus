public static partial class Extension
{
    /// <summary>
    ///     Retrieves the system&#39;s reference to the specified .
    /// </summary>
    /// <param name="this">A string to search for in the intern pool.</param>
    /// <returns>
    ///     The system&#39;s reference to , if it is interned; otherwise, a new reference to a string with the value of .
    /// </returns>
    public static string Intern(this string @this)
    {
        return string.Intern(@this);
    }
}