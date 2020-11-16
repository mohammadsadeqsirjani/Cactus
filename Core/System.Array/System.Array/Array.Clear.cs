// ReSharper disable once CheckNamespace
namespace Core.System.Array
{
    public static partial class Extension
    {
        /// <summary>
        ///     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <param name="array">The  whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this global::System.Array array, int index, int length)
        {
            global::System.Array.Clear(array, index, length);
        }
    }
}
