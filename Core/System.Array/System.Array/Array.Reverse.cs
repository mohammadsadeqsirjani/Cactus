public static partial class Extension
{
    /// <summary>
    ///     Reverses the sequence of the elements in the entire one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    public static void Reverse(this System.Array array)
    {
        System.Array.Reverse(array);
    }

    /// <summary>
    ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
    /// </summary>
    /// <param name="array">The one-dimensional  to reverse.</param>
    /// <param name="index">The starting index of the section to reverse.</param>
    /// <param name="length">The number of elements in the section to reverse.</param>
    public static void Reverse(this System.Array array, int index, int length)
    {
        System.Array.Reverse(array, index, length);
    }
}

