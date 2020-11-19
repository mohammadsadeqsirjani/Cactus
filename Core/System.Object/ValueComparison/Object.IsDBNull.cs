using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns an indication whether the specified object is of type .
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">An object.</param>
    /// <returns>true if  is of type ; otherwise, false.</returns>
    public static bool IsDbNull<T>(this T @this) where T : class
    {
        return Convert.IsDBNull(@this);
    }
}