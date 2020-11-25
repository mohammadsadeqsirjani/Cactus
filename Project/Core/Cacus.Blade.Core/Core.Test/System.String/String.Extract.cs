using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtract
    {
        [TestMethod]
        public void Extract()
        {
            const string @this = "Fizz1Buzz2";

            var result = @this.Extract(c => c.IsNumber());

            Assert.AreEqual("12", result);
        }
    }
}
