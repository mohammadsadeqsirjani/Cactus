using System.Xml.Serialization;

namespace Logging.Configuration.Xml
{
    [XmlRoot("category")]
    public class Category
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("ThrottlingRule ")]
        public string ThrottlingRule { get; set; }

        [XmlArray("providers")]
        [XmlArrayItem("provider")]
        public LogProviderProxy[] LogProviders { get; set; }
    }
}
