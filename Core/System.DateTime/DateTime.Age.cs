namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A DateTime extension method that ages the given this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An int.</returns>
        public static int Age(this global::System.DateTime @this)
        {
            if (global::System.DateTime.Today.Month < @this.Month ||
                global::System.DateTime.Today.Month == @this.Month &&
                global::System.DateTime.Today.Day < @this.Day)
            {
                return global::System.DateTime.Today.Year - @this.Year - 1;
            }
            return global::System.DateTime.Today.Year - @this.Year;
        }
    }
}
