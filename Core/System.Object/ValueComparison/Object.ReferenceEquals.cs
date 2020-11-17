public static partial class Extension
{
    /// <summary>
    ///     Determines whether the specified  instances are the same instance.
    /// </summary>
    /// <param name="this">The first object to compare.</param>
    /// <param name="value">The second object  to compare.</param>
    /// <returns>true if  is the same instance as  or if both are null; otherwise, false.</returns>
    public new static bool ReferenceEquals(this object @this, object value)
    {
        return object.ReferenceEquals(@this, value);
    }
}