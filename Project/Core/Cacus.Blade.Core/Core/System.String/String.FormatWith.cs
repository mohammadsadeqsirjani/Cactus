public static partial class Extension
{
    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static string FormatWith(this string @this, object arg0)
    {
        return string.Format(@this, arg0);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static string FormatWith(this string @this, object arg0, object arg1)
    {
        return string.Format(@this, arg0, arg1);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <param name="arg2">The second argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static string FormatWith(this string @this, object arg0, object arg1, object arg2)
    {
        return string.Format(@this, arg0, arg1, arg2);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">A String containing zero or more format items.</param>
    /// <param name="values">An Object array containing zero or more objects to format.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static string FormatWith(this string @this, params object[] values)
    {
        return string.Format(@this, values);
    }
}