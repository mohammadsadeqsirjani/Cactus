using System;

public static partial class Extension
{
    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="default">The default value.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, TResult @default)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return @default;
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="factory">The default value factory.</param>
    /// <returns>The value or default.</returns>

    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> factory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return factory();
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="factory">The default value factory.</param>
    /// <returns>The value or default.</returns>

    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<T, TResult> factory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return factory(@this);
        }
    }
}