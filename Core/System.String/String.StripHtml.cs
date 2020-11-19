using System.Text;

public static partial class Extension
{
    /// <summary>A string extension method that strip HTML.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string StripHtml(this string @this)
    {
        var path = new StringBuilder(@this);
        var builder = new StringBuilder();

        var position = 0;

        while (position < path.Length)
        {
            var character = path[position];
            position++;

            if (character == '<')
            {
                // LOOP until we close the html tag
                while (position < path.Length)
                {
                    character = path[position];
                    position++;

                    if (character == '>') break;

                    position = character switch
                    {
                        '\'' => GetIndexAfterNextSingleQuote(path, position, true),
                        '"' => GetIndexAfterNextDoubleQuote(path, position, true),
                        _ => position
                    };
                }
            }
            else
            {
                builder.Append(character);
            }
        }

        return builder.ToString();
    }
}