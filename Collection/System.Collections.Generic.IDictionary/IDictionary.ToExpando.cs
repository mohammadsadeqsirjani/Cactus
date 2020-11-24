using System.Collections.Generic;
using System.Dynamic;

public static partial class Extension
{
    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts the @this to an expando.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an ExpandoObject.</returns>
    public static ExpandoObject ToExpando(this IDictionary<string, object> @this)
    {
        var expando = new ExpandoObject();
        var expandoDictionary = (IDictionary<string, object>)expando;

        foreach (var item in @this)
        {
            if (item.Value is IDictionary<string, object> dictionary)
            {
                expandoDictionary.Add(item.Key, dictionary.ToExpando());
            }
            else
            {
                expandoDictionary.Add(item);
            }
        }

        return expando;
    }
}