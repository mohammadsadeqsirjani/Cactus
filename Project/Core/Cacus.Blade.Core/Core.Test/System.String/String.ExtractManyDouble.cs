using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyDouble
    {
        [TestMethod]
        public void ExtractManyDouble()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyDouble();
            var result2 = "12.34Fizz-0.456".ExtractManyDouble();

            Assert.AreEqual(1, result1[0]);
            Assert.AreEqual(-2, result1[1]);
            Assert.AreEqual(12.34, result2[0]);
            Assert.AreEqual(-0.456, result2[1]);
        }
    }
}
