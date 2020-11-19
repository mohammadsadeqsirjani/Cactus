public static partial class Extension
{
    /// <summary>
    ///     Converts the specified  @this to the equivalent OLE Automation Currency @this, which is contained in a 64-bit
    ///     signed integer.
    /// </summary>
    /// <param name="this">The decimal number to convert.</param>
    /// <returns>A 64-bit signed integer that contains the OLE Automation equivalent of .</returns>
    public static long ToOaCurrency(this decimal @this)
    {
        return decimal.ToOACurrency(@this);
    }
}