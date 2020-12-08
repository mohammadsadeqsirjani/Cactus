using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToXDocument
    {
        [TestMethod]
        public void ToXDocument()
        {
            const string @this = "<Fizz>Buzz</Fizz>";

            var value = @this.ToXDocument();

            Assert.AreEqual("<Fizz>Buzz</Fizz>", value.ToString());
        }
    }
}
