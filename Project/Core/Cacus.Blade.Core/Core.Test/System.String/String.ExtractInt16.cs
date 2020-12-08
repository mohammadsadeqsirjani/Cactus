using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractInt16
    {
        [TestMethod]
        public void ExtractInt16()
        {
            var result1 = "Fizz 123 Buzz".ExtractInt16();
            var result2 = "Fizz -123 Buzz".ExtractInt16();
            var result3 = "-Fizz 123 Buzz".ExtractInt16();
            var result4 = "Fizz 123.4 Buzz".ExtractInt16();
            var result5 = "Fizz -123Fizz.Buzz4 Buzz".ExtractInt16();

            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(1234, result4);
            Assert.AreEqual(-1234, result5);
        }
    }
}
