using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="default">The default value.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, T @default)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return @default;
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factory">The default value factory.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, Func<T> factory)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return factory();
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factory">The default value factory.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, Func<object, T> factory)
    {
        try
        {
            return (T)@this;
        }
        catch (Exception)
        {
            return factory(@this);
        }
    }
}