using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that decrypt a string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <returns>The decrypted string.</returns>
    public static string DecryptRsa(this string @this, string key)
    {
        var cpp = new CspParameters { KeyContainerName = key };
        var rsa = new RSACryptoServiceProvider(cpp) { PersistKeyInCsp = true };
        var decryptArray = @this.Split(new[] { "-" }, StringSplitOptions.None);
        var decryptByteArray =
            Array.ConvertAll(decryptArray, (s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))));
        var bytes = rsa.Decrypt(decryptByteArray, true);

        return Encoding.UTF8.GetString(bytes);
    }
}