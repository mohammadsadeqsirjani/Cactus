public static partial class Extension
{
    /// <summary>
    ///     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
    ///     equivalent  value.
    /// </summary>
    /// <param name="this">An OLE Automation Currency value.</param>
    /// <returns>A  that contains the equivalent of .</returns>
    public static decimal FromOaCurrency(this long @this)
    {
        return decimal.FromOACurrency(@this);
    }
}