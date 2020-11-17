using System.Text.RegularExpressions;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that query if 'obj' is valid email.
    /// </summary>
    /// <param name="this">The obj to act on.</param>
    /// <returns>true if valid email, false if not.</returns>
    public static bool IsValidEmail(this string @this)
    {
        return Regex.IsMatch(@this,
            @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
    }
}