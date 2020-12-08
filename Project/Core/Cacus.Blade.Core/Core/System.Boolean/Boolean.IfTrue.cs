using System;

public static partial class Extension
{
    /// <summary>
    ///     A bool extension method that execute an Action if the value is true.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action to execute.</param>
    public static void IfTrue(this bool @this, Action action)
    {
        if (!@this) return;

        action();
    }
}