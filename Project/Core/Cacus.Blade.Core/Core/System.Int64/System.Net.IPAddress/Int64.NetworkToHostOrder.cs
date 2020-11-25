using System.Net;

// ReSharper disable once CheckNamespace
namespace Core.System.Int64
{
    public static partial class Extension
    {
        /// <summary>
        ///     Converts a long value from this byte order to host byte order.
        /// </summary>
        /// <param name="this">The number to convert, expressed in this byte order.</param>
        /// <returns>A long value, expressed in host byte order.</returns>
        public static long NetworkToHostOrder(this long @this)
        {
            return IPAddress.NetworkToHostOrder(@this);
        }
    }
}
