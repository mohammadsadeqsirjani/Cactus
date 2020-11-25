public static partial class Extension
{
    /// <summary>
    ///     Indicates whether a specified string is not null, not empty, or not consists only of white-space characters.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
    public static bool IsNotNullOrWhiteSpace(this string value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
}