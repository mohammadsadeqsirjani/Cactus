using System;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>
    public static T CoalesceOrDefault<T>(this T @this, params T[] values) where T : class
    {
        return @this ?? values.FirstOrDefault(value => value != null);
    }

    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factory">The default value factory.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>

    public static T CoalesceOrDefault<T>(this T @this, Func<T> factory, params T[] values) where T : class
    {
        if (@this != null) return @this;

        foreach (var value in values)
            if (value != null) return value;

        return factory();
    }

    /// <summary>
    ///     A T extension method that that return the first not null value (including the @this) or a default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factory">The default value factory.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>The first not null value or a default value.</returns>

    public static T CoalesceOrDefault<T>(this T @this, Func<T, T> factory, params T[] values) where T : class
    {
        if (@this != null) return @this;

        foreach (var value in values)
            if (value != null) return value;

        return factory(@this);
    }
}