using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectGetValueOrDefault
    {
        [TestMethod]
        public void GetValueOrDefault()
        {
            var @this = new XmlDocument();

            var result1 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, "FizzBuzz");
            var result2 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, () => "FizzBuzz");

            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
        }
    }
}
