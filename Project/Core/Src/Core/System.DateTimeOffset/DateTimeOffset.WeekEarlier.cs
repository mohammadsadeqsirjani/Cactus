using System;

public static partial class Extension
{
    /// <summary>
    /// Increases supplied <see>
    ///     <cref>DateTimeOffSet</cref>
    /// </see>
    /// for 7 days ie returns the Next Week.
    /// </summary>
    public static DateTimeOffset WeekEarlier(this DateTimeOffset start)
    {
        return start - 1.Weeks();
    }
}