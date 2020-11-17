using System;
using System.Collections.Generic;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that return null if the value is empty else the value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>null if the value is empty, otherwise the value.</returns>
    public static string NullIfEmpty(this string @this)
    {
        return @this == "" ? null : @this;
    }
}