using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Blade
{
    /// <summary>
    ///     Provides extension methods to the <see cref="string">System.string</see> object.
    /// </summary>
    public static class Extension
    {
        /// <summary>
        ///     Checks if date with format is parse-able to System.DateTime format returns boolean data if true else false
        /// </summary>
        /// <param name="data">String date</param>
        /// <param name="format">date format example dd/MM/yyyy HH:mm:ss</param>
        /// <returns>boolean True False if is valid System.DateTime</returns>
        public static bool IsDateTime(this string data, string format) => DateTime.TryParseExact(data, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

        /// <summary>
        ///     Converts the string representation of a number to its 32-bit signed integer equivalent
        /// </summary>
        /// <param name="data">string containing a number to convert</param>
        /// <returns>System.Int32</returns>
        /// <remarks>
        ///     The conversion fails if the string parameter is null, is not of the correct format, or represents a number
        ///     less than System.Int32.MinValue or greater than System.Int32.MaxValue
        /// </remarks>
        public static int ToInt32(this string data) => int.TryParse(data, out var number) ? number : default;

        /// <summary>
        ///     Converts the string representation of a number to its 64-bit signed integer equivalent
        /// </summary>
        /// <param name="data">string containing a number to convert</param>
        /// <returns>System.Int64</returns>
        /// <remarks>
        ///     The conversion fails if the string parameter is null, is not of the correct format, or represents a number
        ///     less than System.Int64.MinValue or greater than System.Int64.MaxValue
        /// </remarks>
        public static long ToInt64(this string data) => long.TryParse(data, out var number) ? number : default;

        /// <summary>
        ///     Converts the string representation of a number to its 16-bit signed integer equivalent
        /// </summary>
        /// <param name="data">string containing a number to convert</param>
        /// <returns>System.Int16</returns>
        /// <remarks>
        ///     The conversion fails if the string parameter is null, is not of the correct format, or represents a number
        ///     less than System.Int16.MinValue or greater than System.Int16.MaxValue
        /// </remarks>
        public static short ToInt16(this string data) => short.TryParse(data, out var number) ? number : default;

        /// <summary>
        ///     Converts the string representation of a number to its System.Decimal equivalent
        /// </summary>
        /// <param name="data">string containing a number to convert</param>
        /// <returns>System.Decimal</returns>
        /// <remarks>
        ///     The conversion fails if the data parameter is null, is not a number in a valid format, or represents a number
        ///     less than System.Decimal.MinValue or greater than System.Decimal.MaxValue
        /// </remarks>
        public static decimal ToDecimal(this string data) => decimal.TryParse(data, out var number) ? number : default;

        /// <summary>
        ///     Converts string to its boolean equivalent
        /// </summary>
        /// <param name="data">string to convert</param>
        /// <returns>boolean equivalent</returns>
        /// <remarks>
        ///     <exception cref="ArgumentException">
        ///         thrown in the event no boolean equivalent found or an empty or whitespace
        ///         string is passed
        ///     </exception>
        /// </remarks>
        public static bool ToBoolean(this string data)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                throw new ArgumentException($"The parameter {nameof(data)} doesn't should be null or empty string.");

            var value = data.ToLower().Trim();

            switch (value)
            {
                case "false":
                    return false;
                case "f":
                    return false;
                case "true":
                    return true;
                case "t":
                    return true;
                case "yes":
                    return true;
                case "no":
                    return false;
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    throw new ArgumentException($"{data} can not converted to boolean");
            }
        }

        /// <summary>
        ///     Returns an enumerable collection of the specified type containing the substrings in this instance that are
        ///     delimited by elements of a specified Char array
        /// </summary>
        /// <param name="data">The string.</param>
        /// <param name="separator">
        ///     An array of Unicode characters that delimit the substrings in this instance, an empty array containing no
        ///     delimiters, or null.
        /// </param>
        /// <typeparam name="T">
        ///     The type of the element to return in the collection, this type must implement IConvertible.
        /// </typeparam>
        /// <returns>
        ///     An enumerable collection whose elements contain the substrings in this instance that are delimited by one or more
        ///     characters in separator.
        /// </returns>
        public static IEnumerable<T> SplitTo<T>(this string data, params char[] separator) where T : IConvertible =>
            data.Split(separator, StringSplitOptions.None).Select(str => (T)Convert.ChangeType(str, typeof(T)));

        /// <summary>
        ///     Returns an enumerable collection of the specified type containing the substrings in this instance that are
        ///     delimited by elements of a specified Char array
        /// </summary>
        /// <param name="data">The string.</param>
        /// <param name="options">StringSplitOptions <see cref="StringSplitOptions" /></param>
        /// <param name="separator">
        ///     An array of Unicode characters that delimit the substrings in this instance, an empty array containing no
        ///     delimiters, or null.
        /// </param>
        /// <typeparam name="T">
        ///     The type of the element to return in the collection, this type must implement IConvertible.
        /// </typeparam>
        /// <returns>
        ///     An enumerable collection whose elements contain the substrings in this instance that are delimited by one or more
        ///     characters in separator.
        /// </returns>
        public static IEnumerable<T> SplitTo<T>(this string data, StringSplitOptions options, params char[] separator)
            where T : IConvertible =>
            data.Split(separator, options).Select(s => (T)Convert.ChangeType(s, typeof(T)));

        /// <summary>
        ///     Converts string to its Enum type
        ///     Checks of string is a member of type T enum before converting
        ///     if fails returns default enum
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="data"> The string representation of the enumeration name or underlying data to convert</param>
        /// <param name="defaultValue"></param>
        /// <returns>Enum object</returns>
        /// <remarks>
        ///     <exception cref="ArgumentException">
        ///         enumType is not an System.Enum.-or- data is either an empty string ("") or
        ///         only contains white space.-or- data is a name, but not one of the named constants defined for the enumeration
        ///     </exception>
        /// </remarks>
        public static T ToEnum<T>(this string data, T defaultValue = default(T)) where T : struct
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException($"Type {typeof(T)} Must of type System.Enum");

            var isParsed = Enum.TryParse(data, true, out T result);

            return isParsed ? result : defaultValue;
        }

        /// <summary>
        ///     Replaces one or more format items in a specified string with the string representation of a specified object.
        /// </summary>
        /// <param name="data">A composite format string</param>
        /// <param name="arg">An System.Object to format</param>
        /// <returns>A copy of format in which any format items are replaced by the string representation of arg</returns>
        /// <exception cref="ArgumentNullException">format or args is null.</exception>
        /// <exception>
        ///     format is invalid.-or- The index of a format item is less than zero, or
        ///     greater than or equal to the length of the args array.
        ///     <cref>System.FormatException</cref>
        /// </exception>
        public static string Format(this string data, object arg) => string.Format(data, arg);

        /// <summary>
        ///     Replaces the format item in a specified string with the string representation of a corresponding object in a
        ///     specified array.
        /// </summary>
        /// <param name="data">A composite format string</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        /// <returns>
        ///     A copy of format in which the format items have been replaced by the string representation of the
        ///     corresponding objects in args
        /// </returns>
        /// <exception cref="ArgumentNullException">format or args is null.</exception>
        /// <exception>
        ///     format is invalid.-or- The index of a format item is less than zero, or
        ///     greater than or equal to the length of the args array.
        ///     <cref>System.FormatException</cref>
        /// </exception>
        public static string Format(this string data, params object[] args) => string.Format(data, args);

        /// <summary>
        ///     Gets empty String if passed data is of type Null/Nothing
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>System.String</returns>
        /// <remarks></remarks>
        public static string GetEmptyStringIfNull(this string data) => (data != null ? data.Trim() : "");

        /// <summary>
        ///     Checks if a string is null and returns String if not Empty else returns null/Nothing
        /// </summary>
        /// <param name="data">String data</param>
        /// <returns>null/nothing if String IsEmpty</returns>
        /// <remarks></remarks>
        public static string GetNullIfEmptyString(this string data)
        {
            if (data == null || data.Length <= 0) return null;

            data = data.Trim();

            return data.Length > 0 ? data : null;
        }

        /// <summary>
        ///     IsInteger Function checks if a string is a valid int32 data
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>Boolean True if isInteger else False</returns>
        public static bool IsInteger(this string data)
        {
            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            return int.TryParse(data, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out _);
        }

        /// <summary>
        ///     Read in a sequence of words from standard input and capitalize each
        ///     one (make first letter uppercase; make rest lowercase).
        /// </summary>
        /// <param name="data">string</param>
        /// <returns>Word with capitalization</returns>
        public static string Capitalize(this string data) => data.Length == 0 ? data : $"{data.Substring(0, 1).ToUpper()}{data.Substring(1).ToLower()}";

        /// <summary>
        ///     Gets first character in string
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>System.string</returns>
        public static string FirstCharacter(this string data)
        {
            return (!string.IsNullOrEmpty(data))
                ? (data.Length >= 1)
                    ? data.Substring(0, 1)
                    : data
                : null;
        }

        /// <summary>
        ///     Gets last character in string
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>System.string</returns>
        public static string LastCharacter(this string data)
        {
            return (!string.IsNullOrEmpty(data))
                ? (data.Length >= 1)
                    ? data.Substring(data.Length - 1, 1)
                    : data
                : null;
        }

        /// <summary>
        ///     Check a String ends with another string ignoring the case.
        /// </summary>
        /// <param name="data">string</param>
        /// <param name="suffix">suffix</param>
        /// <returns>true or false</returns>
        public static bool EndsWithIgnoreCase(this string data, string suffix)
        {
            return data == null
                ? throw new ArgumentNullException(nameof(data), "data parameter is null")
                : suffix == null
                    ? throw new ArgumentNullException(nameof(suffix), "suffix parameter is null")
                    : data.Length >= suffix.Length &&
                      data.EndsWith(suffix, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        ///     Check a String starts with another string ignoring the case.
        /// </summary>
        /// <param name="data">string</param>
        /// <param name="prefix">prefix</param>
        /// <returns>true or false</returns>
        public static bool StartsWithIgnoreCase(this string data, string prefix)
        {
            return data == null
                ? throw new ArgumentNullException(nameof(data), "data parameter is null")
                : prefix == null
                    ? throw new ArgumentNullException(nameof(prefix), "prefix parameter is null")
                    : data.Length >= prefix.Length &&
                      data.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        ///     Replace specified characters with an empty string.
        /// </summary>
        /// <param name="data">the string</param>
        /// <param name="chars">list of characters to replace from the string</param>
        /// <example>
        ///     string data = "Friends";
        ///     data = data.Replace('F', 'r','i','data');  //data becomes 'end;
        /// </example>
        /// <returns>System.string</returns>
        public static string Replace(this string data, params char[] chars) => chars.Aggregate(data, (current, c) => current.Replace(c.ToString(CultureInfo.InvariantCulture), ""));

        /// <summary>
        ///     Remove Characters from string
        /// </summary>
        /// <param name="data">string to remove characters</param>
        /// <param name="chars">array of chars</param>
        /// <returns>System.string</returns>
        public static string RemoveChars(this string data, params char[] chars)
        {
            var value = new StringBuilder(data.Length);

            foreach (var character in data.Where(c => !chars.Contains(c))) value.Append(character);

            return value.ToString();
        }

        /// <summary>
        ///     Validate data address
        /// </summary>
        /// <param name="data">string data address</param>
        /// <returns>true or false if data if valid</returns>
        public static bool IsEmailAddress(this string data)
        {
            const string pattern = "^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$";

            return Regex.Match(data, pattern).Success;
        }

        /// <summary>
        ///     IsNumeric checks if a string is a valid floating data
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Boolean True if isNumeric else False</returns>
        /// <remarks></remarks>
        public static bool IsNumeric(this string data)
        {
            // Variable to collect the Return data of the TryParse method.


            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            return double.TryParse(data, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var retNum);
        }

        /// <summary>
        ///     Truncate String and append ... at end
        /// </summary>
        /// <param name="data">String to be truncated</param>
        /// <param name="max">number of chars to truncate</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string Truncate(this string data, int max)
        {
            return string.IsNullOrEmpty(data) || max <= 0
                ? string.Empty
                : data.Length > max
                    ? data.Substring(0, max) + "..."
                    : data;
        }

        /// <summary>
        ///     Function returns a default String data if given data is null or empty
        /// </summary>
        /// <param name="data">String data to check if isEmpty</param>
        /// <param name="defaultValue">default data to return if String data isEmpty</param>
        /// <returns>returns either String data or default data if IsEmpty</returns>
        /// <remarks></remarks>
        public static string GetDefaultIfEmpty(this string data, string defaultValue)
        {
            if (string.IsNullOrEmpty(data)) return defaultValue;

            data = data.Trim();

            return data.Length > 0 ? data : defaultValue;
        }

        /// <summary>
        ///     Convert a string to its equivalent byte array
        /// </summary>
        /// <param name="data">string to convert</param>
        /// <returns>System.byte array</returns>
        public static byte[] ToBytes(this string data)
        {
            var bytes = new byte[data.Length * sizeof(char)];

            Buffer.BlockCopy(data.ToCharArray(), 0, bytes, 0, bytes.Length);

            return bytes;
        }

        /// <summary>
        ///     Reverse string
        /// </summary>
        /// <param name="data">string to reverse</param>
        /// <returns>System.string</returns>
        public static string Reverse(this string data)
        {
            var characters = new char[data.Length];

            for (int i = data.Length - 1, j = 0; i >= 0; --i, ++j) characters[j] = data[i];

            data = new string(characters);

            return data;
        }

        /// <summary>
        ///     Appends String quotes for type CSV data
        /// </summary>
        /// <param name="data">data</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ParseStringToCsv(this string data) => '"' + GetEmptyStringIfNull(data).Replace("\"", "\"\"") + '"';

        /// <summary>
        ///     Encrypt a string using the supplied key. Encoding is done using RSA encryption.
        /// </summary>
        /// <param name="data">String that must be encrypted.</param>
        /// <param name="key">Encryption key</param>
        /// <returns>A string representing a byte array separated by a minus sign.</returns>
        /// <exception cref="ArgumentException">Occurs when data or key is null or empty.</exception>
        public static string Encrypt(this string data, string key)
        {
            var cspParameter = new CspParameters { KeyContainerName = key };

            var rsaServiceProvider = new RSACryptoServiceProvider(cspParameter) { PersistKeyInCsp = true };

            var bytes = rsaServiceProvider.Encrypt(Encoding.UTF8.GetBytes(data), true);

            return BitConverter.ToString(bytes);
        }


        /// <summary>
        ///     Decrypt a string using the supplied key. Decoding is done using RSA encryption.
        /// </summary>
        /// <param name="data">String that must be decrypted.</param>
        /// <param name="key">Decryption key.</param>
        /// <returns>The decrypted string or null if decryption failed.</returns>
        /// <exception cref="ArgumentException">Occurs when data or key is null or empty.</exception>
        public static string Decrypt(this string data, string key)
        {
            var cspParameters = new CspParameters { KeyContainerName = key };

            var rsaServiceProvider = new RSACryptoServiceProvider(cspParameters) { PersistKeyInCsp = true };

            var decryptArray = data.Split(new[] { "-" }, StringSplitOptions.None);

            var decryptByteArray = Array.ConvertAll(decryptArray,
                (s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))));

            var bytes = rsaServiceProvider.Decrypt(decryptByteArray, true);

            var result = Encoding.UTF8.GetString(bytes);

            return result;
        }

        /// <summary>
        ///     Count number of occurrences in string
        /// </summary>
        /// <param name="data">string containing text</param>
        /// <param name="stringToMatch">string or pattern find</param>
        /// <returns></returns>
        public static int CountOccurrences(this string data, string stringToMatch) => Regex.Matches(data, stringToMatch, RegexOptions.IgnoreCase).Count;

        /// <summary>
        ///     Converts a Json string to dictionary object method applicable for single hierarchy objects i.e
        ///     no parent child relationships, for parent child relationships <see cref="JsonToExpanderObject" />
        /// </summary>
        /// <param name="data">string formatted as Json</param>
        /// <returns>IDictionary Json object</returns>
        /// <remarks>
        ///     <exception cref="ArgumentNullException">if string parameter is null or empty</exception>
        /// </remarks>
        public static IDictionary<string, object> JsonToDictionary(this string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException(nameof(data));
            return
                (Dictionary<string, object>)JsonConvert.DeserializeObject(data, typeof(Dictionary<string, object>));
        }

        /// <summary>
        ///     Converts a Json string to ExpandoObject method applicable for multi hierarchy objects i.e
        ///     having zero or many parent child relationships
        /// </summary>
        /// <param name="data">string formatted as Json</param>
        /// <returns>System.Dynamic.ExpandoObject Json object<see cref="ExpandoObject" />ExpandoObject</returns>
        public static dynamic JsonToExpanderObject(this string data)
        {
            var converter = new ExpandoObjectConverter();

            return JsonConvert.DeserializeObject<ExpandoObject>(data, converter);
        }

        /// <summary>
        ///     Converts a Json string to object of type T method applicable for multi hierarchy objects i.e
        ///     having zero or many parent child relationships, Ignore loop references and do not serialize if cycles are detected.
        /// </summary>
        /// <typeparam name="T">object to convert to</typeparam>
        /// <param name="data">data</param>
        /// <returns>object</returns>
        public static T JsonToObject<T>(this string data)
        {
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

            return JsonConvert.DeserializeObject<T>(data, settings);
        }

        /// <summary>
        ///     Removes the first part of the string, if no match found return original string
        /// </summary>
        /// <param name="data">string to remove prefix</param>
        /// <param name="prefix">prefix</param>
        /// <param name="ignoreCase">Indicates whether the compare should ignore case</param>
        /// <returns>trimmed string with no prefix or original string</returns>
        public static string RemovePrefix(this string data, string prefix, bool ignoreCase = true)
        {
            if (!string.IsNullOrEmpty(data) && (ignoreCase ? data.StartsWithIgnoreCase(prefix) : data.StartsWith(prefix)))
                return data.Substring(prefix.Length, data.Length - prefix.Length);

            return data;
        }

        /// <summary>
        ///     Removes the end part of the string, if no match found return original string
        /// </summary>
        /// <param name="data">string to remove suffix</param>
        /// <param name="suffix">suffix</param>
        /// <param name="ignoreCase">Indicates whether the compare should ignore case</param>
        /// <returns>trimmed string with no suffix or original string</returns>
        public static string RemoveSuffix(this string data, string suffix, bool ignoreCase = true)
        {
            if (!string.IsNullOrEmpty(data) && (ignoreCase ? data.EndsWithIgnoreCase(suffix) : data.EndsWith(suffix)))
                return data.Substring(0, data.Length - suffix.Length);

            return null;
        }

        /// <summary>
        ///     Appends the suffix to the end of the string if the string does not already end in the suffix.
        /// </summary>
        /// <param name="data">string to append suffix</param>
        /// <param name="suffix">suffix</param>
        /// <param name="ignoreCase">Indicates whether the compare should ignore case</param>
        /// <returns></returns>
        public static string AppendSuffixIfMissing(this string data, string suffix, bool ignoreCase = true)
        {
            if (string.IsNullOrEmpty(data) || (ignoreCase ? data.EndsWithIgnoreCase(suffix) : data.EndsWith(suffix)))
                return data;

            return data + suffix;
        }

        /// <summary>
        ///     Appends the prefix to the start of the string if the string does not already start with prefix.
        /// </summary>
        /// <param name="data">string to append prefix</param>
        /// <param name="prefix">prefix</param>
        /// <param name="ignoreCase">Indicates whether the compare should ignore case</param>
        /// <returns></returns>
        public static string AppendPrefixIfMissing(this string data, string prefix, bool ignoreCase = true)
        {
            if (string.IsNullOrEmpty(data) || (ignoreCase ? data.StartsWithIgnoreCase(prefix) : data.StartsWith(prefix)))
                return data;

            return prefix + data;
        }

        /// <summary>
        ///     Checks if the String contains only Unicode letters.
        ///     null will return false. An empty String ("") will return false.
        /// </summary>
        /// <param name="data">string to check if is Alpha</param>
        /// <returns>true if only contains letters, and is non-null</returns>
        public static bool IsAlpha(this string data) => !string.IsNullOrEmpty(data) && data.Trim().Replace(" ", "").All(char.IsLetter);

        /// <summary>
        ///     Checks if the String contains only Unicode letters, digits.
        ///     null will return false. An empty String ("") will return false.
        /// </summary>
        /// <param name="data">string to check if is Alpha or Numeric</param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string data) => !string.IsNullOrEmpty(data) && data.Trim().Replace(" ", "").All(char.IsLetterOrDigit);

        /// <summary>
        ///     Convert string to Hash using Sha512
        /// </summary>
        /// <param name="data>string to hash
        /// <param name="data"></param>
        /// </param>
        /// <returns>Hashed string</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string CreateHashSha512(string data)
        {
            if (string.IsNullOrEmpty(data)) throw new ArgumentException(nameof(data));

            var builder = new StringBuilder();

            using (var hash = SHA512.Create())
            {
                var value = hash.ComputeHash(data.ToBytes());
                foreach (var item in value) builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        ///     Convert string to Hash using Sha256
        /// </summary>
        /// <param name="data">string to hash</param>
        /// <returns>Hashed string</returns>
        public static string CreateHashSha256(string data)
        {
            if (string.IsNullOrEmpty(data)) throw new ArgumentException(nameof(data));

            var builder = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                var value = hash.ComputeHash(data.ToBytes());
                foreach (var item in value) builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        ///     Convert url query string to IDictionary data key pair
        /// </summary>
        /// <param name="data">query string data</param>
        /// <returns>IDictionary data key pair</returns>
        public static IDictionary<string, string> QueryStringToDictionary(this string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return null;
            if (!data.Contains("?")) return null;

            var query = data.Replace("?", "");

            if (!query.Contains("=")) return null;

            return query.Split('&')
                .Select(p => p.Split('='))
                .ToDictionary(key => key[0]
                    .ToLower()
                    .Trim(), value => value[1]);
        }

        /// <summary>
        ///     Reverse back or forward slashes
        /// </summary>
        /// <param name="data">string</param>
        /// <param name="direction">
        ///     0 - replace forward slash with back
        ///     1 - replace back with forward slash
        /// </param>
        /// <returns></returns>
        public static string ReverseSlash(this string data, int direction)
        {
            switch (direction)
            {
                case 0:
                    return data.Replace(@"/", @"\");
                case 1:
                    return data.Replace(@"\", @"/");
                default:
                    return data;
            }
        }

        /// <summary>
        ///     Replace Line Feeds
        /// </summary>
        /// <param name="data">string to remove line feeds</param>
        /// <returns>System.string</returns>
        public static string ReplaceLineFeeds(this string data) => Regex.Replace(data, @"^[\r\n]+|\.|[\r\n]+$", "");

        /// <summary>
        ///     Validates if a string is valid IPv4
        ///     Regular expression taken from <a href="http://regexlib.com/REDetails.aspx?regexp_id=2035">Regex reference</a>
        /// </summary>
        /// <param name="data">string IP address</param>
        /// <returns>true if string matches valid IP address else false</returns>
        public static bool IsValidIPv4(this string data)
        {
            if (string.IsNullOrEmpty(data)) return false;
            return Regex.Match(data,
                @"(?:^|\data)([a-z]{3,6}(?=://))?(://)?((?:25[0-5]|2[0-4]\d|[01]?\d\d?)\.(?:25[0-5]|2[0-4]\d|[01]?\d\d?)\.(?:25[0-5]|2[0-4]\d|[01]?\d\d?)\.(?:25[0-5]|2[0-4]\d|[01]?\d\d?))(?::(\d{2,5}))?(?:\data|$)")
                .Success;
        }

        /// <summary>
        ///     Calculates the amount of bytes occupied by the input string encoded as the encoding specified
        /// </summary>
        /// <param name="data">The input string to check</param>
        /// <param name="encoding">The encoding to use</param>
        /// <returns>The total size of the input string in bytes</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">encoding is null</exception>
        public static int GetByteSize(this string data, Encoding encoding)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (encoding == null) throw new ArgumentNullException(nameof(encoding));
            return encoding.GetByteCount(data);
        }

        /// <summary>
        ///     Extracts the left part of the input string limited with the length parameter
        /// </summary>
        /// <param name="data">The input string to take the left part from</param>
        /// <param name="length">The total number characters to take from the input string</param>
        /// <returns>The substring starting at startIndex 0 until length</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Length is smaller than zero or higher than the length of input</exception>
        public static string Left(this string data, int length)
        {
            if (string.IsNullOrEmpty(data)) throw new ArgumentNullException(nameof(data));
            if (length < 0 || length > data.Length)
                throw new ArgumentOutOfRangeException(nameof(length),
                    "length cannot be higher than total string length or less than 0");
            return data.Substring(0, length);
        }

        /// <summary>
        ///     Extracts the right part of the input string limited with the length parameter
        /// </summary>
        /// <param name="data">The input string to take the right part from</param>
        /// <param name="length">The total number characters to take from the input string</param>
        /// <returns>The substring taken from the input string</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Length is smaller than zero or higher than the length of input</exception>
        public static string Right(this string data, int length)
        {
            if (string.IsNullOrEmpty(data)) throw new ArgumentNullException(nameof(data));
            if (length < 0 || length > data.Length)
                throw new ArgumentOutOfRangeException(nameof(length),
                    "length cannot be higher than total string length or less than 0");
            return data.Substring(data.Length - length);
        }

        /// <summary>
        ///     ToTextElements
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IEnumerable<string> ToTextElements(this string data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            var elementEnumerator = StringInfo.GetTextElementEnumerator(data);
            while (elementEnumerator.MoveNext())
            {
                var textElement = elementEnumerator.GetTextElement();
                yield return textElement;
            }
        }

        /// <summary>
        ///     Check if a string does not start with prefix
        /// </summary>
        /// <param name="data">string to evaluate</param>
        /// <param name="prefix">prefix</param>
        /// <returns>true if string does not match prefix else false, null values will always evaluate to false</returns>
        public static bool DoesNotStartWith(this string data, string prefix) =>
            data == null || prefix == null ||
            !data.StartsWith(prefix, StringComparison.InvariantCulture);

        /// <summary>
        ///     Check if a string does not end with prefix
        /// </summary>
        /// <param name="data">string to evaluate</param>
        /// <param name="suffix">suffix</param>
        /// <returns>true if string does not match prefix else false, null values will always evaluate to false</returns>
        public static bool DoesNotEndWith(this string data, string suffix) =>
            data == null || suffix == null ||
            !data.EndsWith(suffix, StringComparison.InvariantCulture);

        /// <summary>
        ///     Checks if a string is null
        /// </summary>
        /// <param name="data">string to evaluate</param>
        /// <returns>true if string is null else false</returns>
        public static bool IsNull(this string data) => data == null;

        /// <summary>
        ///     Checks if a string is null or empty
        /// </summary>
        /// <param name="data">string to evaluate</param>
        /// <returns>true if string is null or is empty else false</returns>
        public static bool IsNullOrEmpty(this string data) => string.IsNullOrEmpty(data);

        /// <summary>
        ///     Checks if string length is a certain minimum number of characters, does not ignore leading and trailing
        ///     white-space.
        ///     null strings will always evaluate to false.
        /// </summary>
        /// <param name="data">string to evaluate minimum length</param>
        /// <param name="minCharLength">minimum allowable string length</param>
        /// <returns>true if string is of specified minimum length</returns>
        public static bool IsMinLength(this string data, int minCharLength) => data != null && data.Length >= minCharLength;

        /// <summary>
        ///     Checks if string length is consists of specified allowable maximum char length. does not ignore leading and
        ///     trailing white-space.
        ///     null strings will always evaluate to false.
        /// </summary>
        /// <param name="data">string to evaluate maximum length</param>
        /// <param name="maxCharLength">maximum allowable string length</param>
        /// <returns>true if string has specified maximum char length</returns>
        public static bool IsMaxLength(this string data, int maxCharLength) => data != null && data.Length <= maxCharLength;

        /// <summary>
        ///     Checks if string length satisfies minimum and maximum allowable char length. does not ignore leading and
        ///     trailing white-space
        /// </summary>
        /// <param name="data">string to evaluate</param>
        /// <param name="minCharLength">minimum char length</param>
        /// <returns>true if string satisfies minimum and maximum allowable length</returns>
        public static bool IsLength(this string data, int minCharLength) => data != null && data.Length >= minCharLength && data.Length <= minCharLength;

        /// <summary>
        ///     Gets the number of characters in string checks if string is null
        /// </summary>
        /// <param name="data">string to evaluate length</param>
        /// <returns>total number of chars or null if string is null</returns>
        public static int? GetLength(this string data) => data?.Length;

        /// <summary>
        ///     Create basic dynamic SQL where parameters from a JSON key data pair string
        /// </summary>
        /// <param name="data">data key data pair string</param>
        /// <param name="useOr">if true constructs parameters using or statement if false and</param>
        /// <returns></returns>
        public static string CreateParameters(this string data, bool useOr)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;

            var searchParameters = data.JsonToDictionary();

            var @params = new StringBuilder("");
            if (searchParameters == null) return @params.ToString();
            for (var i = 0; i <= searchParameters.Count() - 1; i++)
            {
                var key = searchParameters.Keys.ElementAt(i);
                var val = (string)searchParameters[key];

                if (string.IsNullOrEmpty(key)) continue;

                @params.Append(key).Append(" like '").Append(val.Trim()).Append("%' ");

                if (i < searchParameters.Count() - 1 && useOr)
                    @params.Append(" or ");
                else if (i < searchParameters.Count() - 1) @params.Append(" and ");
            }

            return @params.ToString();
        }

        public static string UniqueString(int uniqueLength, int randomLength)
        {
            static long LongRandom(long min, long max, Random random)
            {
                var longRandom = random.Next((int)(min >> 32), (int)(max >> 32));

                longRandom <<= 32;

                longRandom |= random.Next((int)min, (int)max);

                return longRandom;
            }

            static string EncodeInt32AsString(long input, int maxLength = 0)
            {
                var allowedList = new[]
                {
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                    'k', 'l', 'm', 'n', 'n', 'o', 'p', 'q', 'r', 's',
                    't', 'u', 'v', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
                    'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                    'Y', 'Z'
                };

                var allowedSize = allowedList.Length;

                var randomString = new StringBuilder(input.ToString().Length);

                while (input > 0)
                {
                    var moduloResult = input % allowedSize;

                    input /= allowedSize;

                    randomString.Insert(0, allowedList[moduloResult]);
                }

                if (maxLength > randomString.Length) randomString.Insert(0, new string(allowedList[0], maxLength - randomString.Length));

                return maxLength > 0 ? randomString.ToString().Substring(0, maxLength) : randomString.ToString();
            }

            var input = LongRandom(0, int.MaxValue, new Random());

            var random = new StringBuilder(uniqueLength + randomLength);

            var randomize = new Random(
                (int)(
                    DateTime.Now.Ticks + (DateTime.Now.Ticks > input
                        ? DateTime.Now.Ticks / (input + 1)
                        : input / DateTime.Now.Ticks)
                )
            );

            var randomString = EncodeInt32AsString(randomize.Next(1, int.MaxValue), randomLength);

            var uniqueString = EncodeInt32AsString(input, uniqueLength);

            for (var i = 0; i < Math.Min(uniqueLength, randomLength); i++)
                random.AppendFormat("{0}{1}", uniqueString[i], randomString[i]);

            random.Append(
                (uniqueLength < randomLength ? randomString : uniqueString).Substring(Math.Min(uniqueLength,
                    randomLength)));

            return random.ToString();
        }
    }
}
