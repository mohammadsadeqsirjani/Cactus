using System.Text;

public static partial class Extension
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this)
    {
        return @this.ExtractTriviaToken(0);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractTriviaToken(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractTriviaToken(startIndex, out _);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the trivia tokens described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted trivia tokens.</returns>
    public static StringBuilder ExtractTriviaToken(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var builder = new StringBuilder();
        var position = startIndex;

        var isSpace = false;

        while (position < @this.Length)
        {
            var character = @this[position];
            position++;

            if (character == ' ' || character == '\r' || character == '\n' || character == '\t')
            {
                isSpace = true;
                builder.Append(character);
            }
            else if (character == '/' && !isSpace)
            {
                if (position >= @this.Length) continue;

                character = @this[position];

                switch (character)
                {
                    case '/':
                        return @this.ExtractCommentSingleLine(startIndex, out endIndex);
                    case '*':
                        return @this.ExtractCommentMultiLine(startIndex, out endIndex);
                }

                // otherwise is probably the divide operator
                position--;
                break;
            }
            else
            {
                position -= 2;
                break;
            }
        }

        if (isSpace)
        {
            endIndex = position;
            return builder;
        }

        endIndex = -1;
        return null;
    }
}