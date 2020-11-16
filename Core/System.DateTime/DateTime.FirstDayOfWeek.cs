namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A DateTime extension method that first day of week.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime.</returns>
        public static global::System.DateTime FirstDayOfWeek(this global::System.DateTime @this)
        {
            return new global::System.DateTime(@this.Year, @this.Month, @this.Day).AddDays(-(int)@this.DayOfWeek);
        }
    }
}
