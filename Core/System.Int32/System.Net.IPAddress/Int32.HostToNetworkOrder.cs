using System.Net;

// ReSharper disable once CheckNamespace
namespace Core.System.Int32
{
    public static partial class Extension
    {
        /// <summary>
        ///     Converts an integer value from this byte order to network byte order.
        /// </summary>
        /// <param name="this">The number to convert, expressed in this byte order.</param>
        /// <returns>An integer value, expressed in network byte order.</returns>
        public static int HostToNetworkOrder(this int @this)
        {
            return IPAddress.HostToNetworkOrder(@this);
        }
    }
}
