using System.Text;

public static partial class Extension
{
    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this)
    {
        return @this.ExtractNumber(0);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractNumber(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractNumber(startIndex, out _);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support all kind of suffix for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character
        var builder = new StringBuilder();

        var hasNumber = false;
        var hasDot = false;
        var hasSuffix = false;

        var position = startIndex;

        while (position < @this.Length)
        {
            var character = @this[position];
            position++;

            if (character >= '0' && character <= '9' && !hasSuffix)
            {
                hasNumber = true;
                builder.Append(character);
            }
            else if (character == '.' && !hasSuffix && !hasDot)
            {
                hasDot = true;
                builder.Append(character);
            }
            else if (character >= 'a' && character <= 'z' || character >= 'A' && character <= 'Z')
            {
                hasSuffix = true;
                builder.Append(character);
            }
            else
            {
                position -= 2;
                break;
            }
        }

        if (hasNumber)
        {
            endIndex = position;
            return builder;
        }

        endIndex = -1;
        return null;
    }
}