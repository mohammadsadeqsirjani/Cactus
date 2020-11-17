using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this)
    {
        return @this.ExtractCommentMultiLine(0);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractCommentMultiLine(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractCommentMultiLine(startIndex, out _);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var builder = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var firstCharacter = @this[startIndex];
            var secondCharacter = @this[startIndex + 1];

            if (firstCharacter == '/' && secondCharacter == '*')
            {
                /*
                 * Multi-line comment
                 */

                builder.Append(firstCharacter);
                builder.Append(secondCharacter);

                var position = startIndex + 2;

                while (position < @this.Length)
                {
                    var character = @this[position];

                    position++;

                    if (character == '*' && position < @this.Length && @this[position] == '/')
                    {
                        builder.Append(character);
                        builder.Append(@this[position]);

                        endIndex = position;

                        return builder;
                    }

                    builder.Append(character);
                }

                endIndex = position;

                return builder;
            }
        }

        endIndex = -1;

        return null;
    }
}