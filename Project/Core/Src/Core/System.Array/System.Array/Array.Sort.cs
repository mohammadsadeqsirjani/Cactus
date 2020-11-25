using System.Collections;

public static partial class Extension
{
    /// <summary>
    ///     Sorts the elements in an entire one-dimensional  using the  implementation of each element of the .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    public static void Sort(this System.Array array)
    {
        System.Array.Sort(array);
    }

    /// <summary>
    ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
    ///     items) based on the keys in the first  using the  implementation of each key.
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">
    ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
    ///     null to sort only the .
    /// </param>
    /// ###
    public static void Sort(this System.Array array, System.Array items)
    {
        System.Array.Sort(array, items);
    }

    /// <summary>
    ///     Sorts the elements in a range of elements in a one-dimensional  using the  implementation of each element of
    ///     the .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    public static void Sort(this System.Array array, int index, int length)
    {
        System.Array.Sort(array, index, length);
    }

    /// <summary>
    ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
    ///     the corresponding items) based on the keys in the first  using the  implementation of each key.
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">
    ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
    ///     null to sort only the .
    /// </param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// ###
    public static void Sort(this System.Array array, System.Array items, int index, int length)
    {
        System.Array.Sort(array, items, index, length);
    }

    /// <summary>
    ///     Sorts the elements in a one-dimensional  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
    ///     each element.
    /// </param>
    public static void Sort(this System.Array array, IComparer comparer)
    {
        System.Array.Sort(array, comparer);
    }

    /// <summary>
    ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
    ///     items) based on the keys in the first  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">
    ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
    ///     null to sort only the .
    /// </param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
    ///     each element.
    /// </param>
    /// ###
    public static void Sort(this System.Array array, System.Array items, IComparer comparer)
    {
        System.Array.Sort(array, items, comparer);
    }

    /// <summary>
    ///     Sorts the elements in a range of elements in a one-dimensional  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
    ///     each element.
    /// </param>
    public static void Sort(this System.Array array, int index, int length, IComparer comparer)
    {
        System.Array.Sort(array, index, length, comparer);
    }

    /// <summary>
    ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
    ///     the corresponding items) based on the keys in the first  using the specified .
    /// </summary>
    /// <param name="array">The one-dimensional  to sort.</param>
    /// <param name="items">
    ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
    ///     null to sort only the .
    /// </param>
    /// <param name="index">The starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <param name="comparer">
    ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
    ///     each element.
    /// </param>
    /// ###
    public static void Sort(this System.Array array, System.Array items, int index, int length,
        IComparer comparer)
    {
        System.Array.Sort(array, items, index, length, comparer);
    }
}
