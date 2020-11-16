public static partial class Extension
{
    /// <summary>
    ///     Retrieves the byte at a specified location in a specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <param name="index">A location in the array.</param>
    /// <returns>Returns the  byte in the array.</returns>
    public static byte GetByte(this System.Array array, int index)
    {
        return System.Buffer.GetByte(array, index);
    }
}
