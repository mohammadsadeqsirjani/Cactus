public static partial class Extension
{
    /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
    /// <param name="this">this.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this System.Environment.SpecialFolder @this)
    {
        return System.Environment.GetFolderPath(@this);
    }

    /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
    /// <param name="this">this.</param>
    /// <param name="option">The option.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this System.Environment.SpecialFolder @this,
        System.Environment.SpecialFolderOption option)
    {
        return System.Environment.GetFolderPath(@this, option);
    }
}