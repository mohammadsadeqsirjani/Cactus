public static partial class Extension
{
    /// <summary>
    ///     Deserializes a 64-bit binary value and recreates an original serialized  object.
    /// </summary>
    /// <param name="this">
    ///     A 64-bit signed integer that encodes the  property in a 2-bit field and the  property in
    ///     a 62-bit field.
    /// </param>
    /// <returns>An object that is equivalent to the  object that was serialized by the  method.</returns>
    public static System.DateTime FromBinary(this long @this)
    {
        return System.DateTime.FromBinary(@this);
    }
}