using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the comment single line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted comment single line.</returns>
    public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this)
    {
        return @this.ExtractCommentSingleLine(0);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment single line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment single line.</returns>
    public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractCommentSingleLine(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment single line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted comment single line.</returns>
    public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractCommentSingleLine(startIndex, out _);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment single line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment single line.</returns>
    public static StringBuilder ExtractCommentSingleLine(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var builder = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var firstCharacter = @this[startIndex];
            var secondCharacter = @this[startIndex + 1];

            if (firstCharacter == '/' && secondCharacter == '/')
            {
                // Single line comment

                builder.Append(firstCharacter);
                builder.Append(secondCharacter);

                var position = startIndex + 2;

                while (position < @this.Length)
                {
                    var character = @this[position];

                    position++;

                    if (character == '\r' && position < @this.Length && @this[position] == '\n')
                    {
                        endIndex = position - 1;
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