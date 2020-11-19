using System.IO;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     Combines multiples string into a path.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="paths">A variable-length parameters list containing paths.</param>
    /// <returns>
    ///     The combined paths. If one of the specified paths is a zero-length string, this method returns the other path.
    /// </returns>
    public static string PathCombine(this string @this, params string[] paths)
    {
        var list = paths.ToList();
        list.Insert(0, @this);
        return Path.Combine(list.ToArray());
    }
}