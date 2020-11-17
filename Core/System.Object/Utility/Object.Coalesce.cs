using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this).
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value.</returns>
    public static T Coalesce<T>(this T @this, params T[] values) where T : class
    {
        return @this ?? values.FirstOrDefault(value => value != null);
    }
}