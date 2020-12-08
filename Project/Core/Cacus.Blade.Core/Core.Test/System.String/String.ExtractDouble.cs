using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractDouble
    {
        [TestMethod]
        public void ExtractDouble()
        {
            var result1 = "Fizz 123 Buzz".ExtractDouble();
            var result2 = "Fizz -123 Buzz".ExtractDouble();
            var result3 = "-Fizz 123 Buzz".ExtractDouble();
            var result4 = "Fizz 123.456 Buzz".ExtractDouble();
            var result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractDouble();

            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(123.456, result4);
            Assert.AreEqual(-123.456, result5);
        }
    }
}
