using System.Globalization;

public static partial class Extension
{
    /// <summary>
    ///     Categorizes a specified Unicode @this into a group identified by one of the  values.
    /// </summary>
    /// <param name="this">The Unicode @this to categorize.</param>
    /// <returns>A  value that identifies the group that contains .</returns>
    public static UnicodeCategory GetUnicodeCategory(this char @this)
    {
        return char.GetUnicodeCategory(@this);
    }
}
