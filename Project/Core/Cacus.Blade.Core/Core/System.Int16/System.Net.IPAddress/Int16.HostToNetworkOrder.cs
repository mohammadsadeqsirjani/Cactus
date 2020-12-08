using System.Net;

public static partial class Extension
{
    /// <summary>
    ///     Converts a short value from @this byte order to network byte order.
    /// </summary>
    /// <param name="this">The number to convert, expressed in @this byte order.</param>
    /// <returns>A short value, expressed in network byte order.</returns>
    public static short HostToNetworkOrder(this short @this)
    {
        return IPAddress.HostToNetworkOrder(@this);
    }
}