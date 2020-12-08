using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIfEmpty
    {
        [TestMethod]
        public void IfEmpty()
        {
            const string @this = "";

            var result = @this.IfEmpty("FizzBuzz");

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
