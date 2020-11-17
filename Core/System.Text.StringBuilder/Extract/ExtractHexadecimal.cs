using System.Text;

public static partial class Extension
{
    /// <summary>A StringBuilder extension method that extracts the hexadecimal described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted hexadecimal.</returns>
    public static StringBuilder ExtractHexadecimal(this StringBuilder @this)
    {
        return @this.ExtractHexadecimal(0);
    }

    /// <summary>A StringBuilder extension method that extracts the hexadecimal described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted hexadecimal.</returns>
    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractHexadecimal(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the hexadecimal described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted hexadecimal.</returns>
    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractHexadecimal(startIndex, out _);
    }

    /// <summary>A StringBuilder extension method that extracts the hexadecimal described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted hexadecimal.</returns>
    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support all kind of suffix for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character

        if (startIndex + 1 < @this.Length && @this[startIndex] == '0'
            && (@this[startIndex + 1] == 'x' || @this[startIndex + 1] == 'X'))
        {
            var builder = new StringBuilder();

            var hasNumber = false;
            var hasSuffix = false;

            builder.Append(@this[startIndex]);
            builder.Append(@this[startIndex + 1]);

            var position = startIndex + 2;

            while (position < @this.Length)
            {
                var character = @this[position];

                position++;

                if ((character >= '0' && character <= '9' ||
                     character >= 'a' && character <= 'f' ||
                     character >= 'A' && character <= 'F')
                    && !hasSuffix)
                {
                    hasNumber = true;
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
        }

        endIndex = -1;

        return null;
    }
}