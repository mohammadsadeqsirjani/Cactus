public static partial class Extension
{
    /// <summary>
    ///     Converts the value of a specified instance of  to its equivalent binary representation.
    /// </summary>
    /// <param name="d">The value to convert.</param>
    /// <returns>A 32-bit signed integer array with four elements that contain the binary representation of .</returns>
    public static int[] GetBits(this decimal d)
    {
        return decimal.GetBits(d);
    }
}