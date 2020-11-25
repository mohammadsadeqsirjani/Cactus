using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyInt16
    {
        [TestMethod]
        public void ExtractManyInt16()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyInt16();
            var result2 = "12.34Fizz-0.456".ExtractManyInt16();

            Assert.AreEqual(1, result1[0]);
            Assert.AreEqual(-2, result1[1]);
            Assert.AreEqual(12, result2[0]);
            Assert.AreEqual(34, result2[1]);
            Assert.AreEqual(0, result2[2]);
            Assert.AreEqual(456, result2[3]);
        }
    }
}
