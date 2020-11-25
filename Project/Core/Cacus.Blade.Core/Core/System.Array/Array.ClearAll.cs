public static partial class Extension
{
    /// <summary>
    ///     An Array extension method that clears the array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void ClearAll(this System.Array @this)
    {
        System.Array.Clear(@this, 0, @this.Length);
    }
}

