public static partial class Extension
{
    /// <summary>
    ///     Indicates whether a specified string is null, empty, or consists only of white-space characters.
    /// </summary>
    /// <param name="this">The string to test.</param>
    /// <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
    public static bool IsNullOrWhiteSpace(this string @this)
    {
        return string.IsNullOrWhiteSpace(@this);
    }
}