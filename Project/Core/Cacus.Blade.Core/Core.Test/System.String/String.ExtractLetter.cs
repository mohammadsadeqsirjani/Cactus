using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractLetter
    {
        [TestMethod]
        public void ExtractLetter()
        {
            const string @this = "Fizz1Buzz2";

            var result = @this.ExtractLetter();

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
