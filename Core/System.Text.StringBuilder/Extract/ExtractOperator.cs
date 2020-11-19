using System.Text;

public static partial class Extension
{
    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this)
    {
        return @this.ExtractOperator(0);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractOperator(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractOperator(startIndex, out _);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support custom operator for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character
        var builder = new StringBuilder();

        var position = startIndex;

        while (position < @this.Length)
        {
            var character = @this[position];

            position++;

            switch (character)
            {
                case '`':
                case '~':
                case '!':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '-':
                case '_':
                case '=':
                case '+':
                case '[':
                case ']':
                case '{':
                case '}':
                case '|':
                case ':':
                case ';':
                case ',':
                case '.':
                case '<':
                case '>':
                case '?':
                case '/':
                    builder.Append(character);
                    break;
                default:
                    if (builder.Length > 0)
                    {
                        endIndex = position - 2;
                        return builder;
                    }

                    endIndex = -1;
                    return null;
            }
        }

        if (builder.Length > 0)
        {
            endIndex = position;
            return builder;
        }

        endIndex = -1;
        return null;
    }
}