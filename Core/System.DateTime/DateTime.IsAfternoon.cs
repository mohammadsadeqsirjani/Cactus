namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A DateTime extension method that query if '@this' is afternoon.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if afternoon, false if not.</returns>
        public static bool IsAfternoon(this global::System.DateTime @this)
        {
            return @this.TimeOfDay >= new global::System.DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
        }
    }
}
