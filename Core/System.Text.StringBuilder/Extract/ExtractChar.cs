using System;
using System.Text;

public static partial class Extension
{
    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this)
    {
        return @this.ExtractChar(0);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractChar(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, int startIndex)
    {
        return @this.ExtractChar(startIndex, out _);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, int startIndex, out int endIndex)
    {
        if (@this.Length <= startIndex + 1)
            throw new Exception("Invalid char at position: " + startIndex);

        var firstCharacter = @this[startIndex];
        var secondCharacter = @this[startIndex + 1];
        var thirdCharacter = @this[startIndex + 2];

        if (firstCharacter != '\'' || thirdCharacter != '\'')
            throw new Exception("Invalid char at position: " + startIndex);

        endIndex = startIndex + 2;

        return secondCharacter;

    }
}