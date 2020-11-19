using System.Text;

public static partial class Extension
{
    /// <summary>A StringBuilder extension method that extracts the keyword described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted keyword.</returns>
    public static StringBuilder ExtractKeyword(this StringBuilder @this)
    {
        return @this.ExtractKeyword(0);
    }

    /// <summary>A StringBuilder extension method that extracts the keyword described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted keyword.</returns>
    public static StringBuilder ExtractKeyword(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractKeyword(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the keyword described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted keyword.</returns>
    public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractKeyword(startIndex, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the keyword described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted keyword.</returns>
    public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support custom operator for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character

        var builder = new StringBuilder();

        var position = startIndex;

        var hasCharacter = false;

        while (position < @this.Length)
        {
            var character = @this[position];

            position++;

            if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
            {
                hasCharacter = true;
                builder.Append(character);
            }
            else if (character == '@')
            {
                builder.Append(character);
            }
            else if (character >= '0' && character <= '9' && hasCharacter)
            {
                builder.Append(character);
            }
            else
            {
                position -= 2;
                break;
            }
        }

        if (hasCharacter)
        {
            endIndex = position;
            return builder;
        }

        endIndex = -1;

        return null;
    }
}