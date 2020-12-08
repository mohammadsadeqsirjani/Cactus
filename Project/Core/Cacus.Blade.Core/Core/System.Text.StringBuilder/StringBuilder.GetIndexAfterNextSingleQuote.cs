using System.Text;

public static partial class Extension
{
    /// <summary>Gets index after next single quote.</summary>
    /// <param name="this">Full pathname of the file.</param>
    /// <returns>The index after next single quote.</returns>
    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this)
    {
        return @this.GetIndexAfterNextSingleQuote(0, false);
    }

    /// <summary>Gets index after next single quote.</summary>
    /// <param name="this">Full pathname of the file.</param>
    /// <param name="allowEscape">true to allow, false to deny escape.</param>
    /// <returns>The index after next single quote.</returns>
    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, bool allowEscape)
    {
        return @this.GetIndexAfterNextSingleQuote(0, allowEscape);
    }

    /// <summary>Gets index after next single quote.</summary>
    /// <param name="this">Full pathname of the file.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The index after next single quote.</returns>
    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex)
    {
        return @this.GetIndexAfterNextSingleQuote(startIndex, false);
    }

    /// <summary>Gets index after next single quote.</summary>
    /// <param name="this">Full pathname of the file.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="allowEscape">true to allow, false to deny escape.</param>
    /// <returns>The index after next single quote.</returns>
    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex, bool allowEscape)
    {
        while (startIndex < @this.Length)
        {
            var character = @this[startIndex];

            startIndex++;

            char nextChar;

            if (allowEscape && character == '\\' && startIndex < @this.Length && ((nextChar = @this[startIndex]) == '\\' || nextChar == '\''))
            {
                startIndex++; // Treat as escape character for \\ or \'
            }
            else if (character == '\'')
            {
                return startIndex;
            }
        }

        return startIndex;
    }
}