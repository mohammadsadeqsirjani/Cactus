using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToXmlDocument
    {
        [TestMethod]
        public void ToXmlDocument()
        {
            const string @this = "<Fizz>Buzz</Fizz>";

            var value = @this.ToXmlDocument();

            Assert.AreEqual("<Fizz>Buzz</Fizz>", value.OuterXml);
        }
    }
}
