using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractDecimal
    {
        [TestMethod]
        public void ExtractDecimal()
        {
            var result1 = "Fizz 123 Buzz".ExtractDecimal();
            var result2 = "Fizz -123 Buzz".ExtractDecimal();
            var result3 = "-Fizz 123 Buzz".ExtractDecimal();
            var result4 = "Fizz 123.456 Buzz".ExtractDecimal();
            var result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractDecimal();

            Assert.AreEqual(123M, result1);
            Assert.AreEqual(-123M, result2);
            Assert.AreEqual(123M, result3);
            Assert.AreEqual(123.456M, result4);
            Assert.AreEqual(-123.456M, result5);
        }
    }
}
