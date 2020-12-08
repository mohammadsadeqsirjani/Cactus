using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyDecimal
    {
        [TestMethod]
        public void ExtractManyDecimal()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyDecimal();
            var result2 = "12.34Fizz-0.456".ExtractManyDecimal();

            Assert.AreEqual(1M, result1[0]);
            Assert.AreEqual(-2M, result1[1]);
            Assert.AreEqual(12.34M, result2[0]);
            Assert.AreEqual(-0.456M, result2[1]);
        }
    }
}
