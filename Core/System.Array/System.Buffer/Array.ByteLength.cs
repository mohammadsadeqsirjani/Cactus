public static partial class Extension
{
    /// <summary>
    ///     Returns the number of bytes in the specified array.
    /// </summary>
    /// <param name="array">An array.</param>
    /// <returns>The number of bytes in the array.</returns>
    public static int ByteLength(this System.Array array)
    {
        return System.Buffer.ByteLength(array);
    }
}

