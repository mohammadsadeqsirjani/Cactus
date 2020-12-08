using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractInt64
    {
        [TestMethod]
        public void ExtractInt64()
        {
            var result1 = "Fizz 123 Buzz".ExtractInt64();
            var result2 = "Fizz -123 Buzz".ExtractInt64();
            var result3 = "-Fizz 123 Buzz".ExtractInt64();
            var result4 = "Fizz 123.456 Buzz".ExtractInt64();
            var result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractInt64();

            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(123456, result4);
            Assert.AreEqual(-123456, result5);
        }
    }
}
