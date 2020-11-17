using System;
using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the string single quote described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted string single quote.</returns>
    public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this)
    {
        return @this.ExtractStringSingleQuote(0);
    }

    /// <summary>A StringBuilder extension method that extracts the string single quote described by
    /// @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string single quote.</returns>
    public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractStringSingleQuote(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the string single quote described by
    ///     @this.
    /// </summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted string single quote.</returns>
    public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractStringSingleQuote(startIndex, out _);
    }

    /// <summary>A StringBuilder extension method that extracts the string single quote described by
    /// @this.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string single quote.</returns>
    public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var builder = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var firstCharacter = @this[startIndex];

            if (firstCharacter == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // 'my string'

                var position = startIndex + 1;

                while (position < @this.Length)
                {
                    var character = @this[position];
                    position++;

                    char nextChar;

                    switch (character)
                    {
                        case '\\' when position < @this.Length && ((nextChar = @this[position]) == '\\' || nextChar == '\''):
                            builder.Append(nextChar);
                            position++; // Treat as escape character for \\ or \"
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