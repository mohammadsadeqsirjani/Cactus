using System;
using System.IO;
using System.Security.Cryptography;

namespace Cactus.Blade.Caching.Helper
{
    /// <summary>
    /// Helpers for encrypting and decrypting.
    /// </summary>
    /// <remarks>
    /// Originally inspired by https://msdn.microsoft.com/en-us/library/system.security.cryptography.aesmanaged(v=vs.110).aspx
    /// </remarks>
    public class CryptographyHelpers
    {
        public static string Decrypt(string password, string salt, string encrypted_value)
        {
            using var aes = Aes.Create();

            var (key, iv) = GetAesKeyAndIv(password, salt, aes);

            aes.Key = key;
            aes.IV = iv;

            var decryption = aes.CreateDecryptor(aes.Key, aes.IV);

            var encryptedBytes = ToByteArray(encrypted_value);

            using var memoryStream = new MemoryStream(encryptedBytes);
            using var cryptoStream = new CryptoStream(memoryStream, decryption, CryptoStreamMode.Read);
            using var reader = new StreamReader(cryptoStream);

            var decrypted = reader.ReadToEnd();

            return decrypted;
        }

        public static string Encrypt(string password, string salt, string plain_text)
        {
            using var aes = Aes.Create();

            var (key, iv) = GetAesKeyAndIv(password, salt, aes);

            aes.Key = key;
            aes.IV = iv;

            var encryption = aes.CreateEncryptor(aes.Key, aes.IV);

            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, encryption, CryptoStreamMode.Write);
            using var writer = new StreamWriter(cryptoStream);

            writer.Write(plain_text);

            var encryptedBytes = memoryStream.ToArray();
            var encrypted = ToString(encryptedBytes);

            return encrypted;
        }

        private static byte[] ToByteArray(string input)
        {
            var validBase64 = input.Replace('-', '+');

            return Convert.FromBase64String(validBase64);
        }

        private static string ToString(byte[] input)
        {
            return Convert.ToBase64String(input);
        }

        private static Tuple<byte[], byte[]> GetAesKeyAndIv(string password, string salt,
            SymmetricAlgorithm symmetricAlgorithm)
        {
            const int bits = 8;

            var deriveBytes = new Rfc2898DeriveBytes(password, ToByteArray(salt));

            var key = deriveBytes.GetBytes(symmetricAlgorithm.KeySize / bits);
            var iv = deriveBytes.GetBytes(symmetricAlgorithm.BlockSize / bits);

            return new Tuple<byte[], byte[]>(key, iv);
        }
    }
}
