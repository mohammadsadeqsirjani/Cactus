using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a date time off set or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSetOrDefault(this object @this)
    {
        try
        {
            return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
        }
        catch (Exception)
        {
            return default;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a date time off set or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSetOrDefault(this object @this, DateTimeOffset defaultValue)
    {
        try
        {
            return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to a date time off set or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSetOrDefault(this object @this, DateTimeOffset defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a date time off set or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSetOrDefault(this object @this, Func<DateTimeOffset> defaultValueFactory)
    {
        try
        {
            return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to a date time off set or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a DateTimeOffset.</returns>
    public static DateTimeOffset ToDateTimeOffSetOrDefault(this object @this, Func<DateTimeOffset> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null) return defaultValueFactory();

        try
        {
            return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}