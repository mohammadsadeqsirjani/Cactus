using System;

public static partial class Extension
{
    /// <summary>A T extension method that execute an action when the value is not null.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    public static void IfNotNull<T>(this T @this, Action<T> action) where T : class
    {
        if (@this != null) action(@this);
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func) where T : class
    {
        return @this != null ? func(@this) : default;
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="default">The default value.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, TResult @default) where T : class
    {
        return @this != null ? func(@this) : @default;
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="factory">The default value factory.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> factory) where T : class
    {
        return @this != null ? func(@this) : factory();
    }
}