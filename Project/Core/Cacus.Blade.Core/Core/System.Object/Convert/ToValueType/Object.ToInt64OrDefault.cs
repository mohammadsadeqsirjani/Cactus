using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to an int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a long.</returns>
    public static long ToInt64OrDefault(this object @this)
    {
        try
        {
            return Convert.ToInt64(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a long.</returns>
    public static long ToInt64OrDefault(this object @this, long defaultValue)
    {
        try
        {
            return Convert.ToInt64(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a long.</returns>
    public static long ToInt64OrDefault(this object @this, long defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValue;

        try
        {
            return Convert.ToInt64(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a long.</returns>
    public static long ToInt64OrDefault(this object @this, Func<long> defaultValueFactory)
    {
        try
        {
            return Convert.ToInt64(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a long.</returns>
    public static long ToInt64OrDefault(this object @this, Func<long> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValueFactory();

        try
        {
            return Convert.ToInt64(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}