using System.Xml;

public static partial class Extension
{
    /// <summary>
    ///     A string extension method that converts the @this to an XmlDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XmlDocument.</returns>
    public static XmlDocument ToXmlDocument(this string @this)
    {
        var document = new XmlDocument();
        document.LoadXml(@this);
        return document;
    }
}