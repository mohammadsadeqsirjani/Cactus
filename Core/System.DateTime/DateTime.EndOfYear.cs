using System;

namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A DateTime extension method that return a DateTime of the last day of the year with the time set to
        ///     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
        ///     precision.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
        public static global::System.DateTime EndOfYear(this global::System.DateTime @this)
        {
            return new global::System.DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }
    }
}
