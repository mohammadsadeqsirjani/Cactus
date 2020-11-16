// ReSharper disable once CheckNamespace
namespace Core.System.Decimal
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        /// <param name="this">A decimal number.</param>
        /// <returns>
        ///     The largest integer less than or equal to .  Note that the method returns an integral value of type .
        /// </returns>
        public static decimal Floor(this decimal @this)
        {
            return global::System.Math.Floor(@this);
        }
    }
}
