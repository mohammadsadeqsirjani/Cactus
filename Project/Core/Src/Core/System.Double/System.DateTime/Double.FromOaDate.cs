public static partial class Extension
{
    /// <summary>
    ///     Returns a  equivalent to the specified OLE Automation Date.
    /// </summary>
    /// <param name="this">An OLE Automation Date value.</param>
    /// <returns>An object that represents the same date and time as .</returns>
    public static System.DateTime FromOaDate(this double @this)
    {
        return System.DateTime.FromOADate(@this);
    }
}