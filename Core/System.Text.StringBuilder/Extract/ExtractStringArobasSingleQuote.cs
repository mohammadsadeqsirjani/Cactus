using System;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the string arobas single quote
    ///     described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted string arobas single quote.</returns>
    public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this)
    {
        return @this.ExtractStringArobasSingleQuote(0);
    }
    /// <summary>A StringBuilder extension method that extracts the string arobas single quote
    /// described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string arobas single quote.</returns>
    public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractStringArobasSingleQuote(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the string arobas single quote
    ///     described by @this.
    /// </summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted string arobas single quote.</returns>
    public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
    }
    /// <summary>A StringBuilder extension method that extracts the string arobas single quote
    /// described by @this.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string arobas single quote.</returns>
    public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var builder = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var firstCharacter = @this[startIndex];
            var secondCharacter = @this[startIndex + 1];

            if (firstCharacter == '@' && secondCharacter == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // @'my string'

                var position = startIndex + 2;

                while (position < @this.Length)
                {
                    var character = @this[position];

                    position++;

                    switch (character)
                    {
                        case '\'' when position < @this.Length && @this[position] == '\'':
                            builder.Append(character);
                            position++; // Treat as escape character for @'abc''def'
                            break;
                        case '\'':
                            endIndex = position;
                            return builder;
                        default:
                            builder.Append(character);
                            break;
                    }
                }

                throw new Exception("Unclosed string starting at position: " + startIndex);
            }
        }

        endIndex = -1;
        return null;
    }
}