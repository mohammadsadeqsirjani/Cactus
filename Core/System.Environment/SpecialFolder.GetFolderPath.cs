namespace Core.System.Environment
{
    public static partial class Extension
    {
        /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
        /// <param name="this">this.</param>
        /// <returns>The folder path.</returns>
        public static string GetFolderPath(this global::System.Environment.SpecialFolder @this)
        {
            return global::System.Environment.GetFolderPath(@this);
        }

        /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
        /// <param name="this">this.</param>
        /// <param name="option">The option.</param>
        /// <returns>The folder path.</returns>
        public static string GetFolderPath(this global::System.Environment.SpecialFolder @this,
            global::System.Environment.SpecialFolderOption option)
        {
            return global::System.Environment.GetFolderPath(@this, option);
        }
    }
}
