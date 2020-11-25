using System.Collections.Generic;

public static partial class Extension
{
    /// <summary>
    /// An ICollection&lt;T&gt; extension method that swaps item only when it exists in a collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>
    /// true if it succeeds, false if it fails.
    /// </returns>
    public static void Swap<T>(this IList<T> @this, T oldValue, T newValue)
    {
        var oldIndex = @this.IndexOf(oldValue);

        while (oldIndex > 0)
        {
            @this.RemoveAt(oldIndex);
            @this.Insert(oldIndex, newValue);
            oldIndex = @this.IndexOf(oldValue);
        }
    }
}
