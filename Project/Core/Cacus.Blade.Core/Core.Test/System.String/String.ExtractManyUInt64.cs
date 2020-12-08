using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyUInt64
    {
        [TestMethod]
        public void ExtractManyUInt64()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyUInt64();
            var result2 = "12.34Fizz-0.456".ExtractManyUInt64();

            Assert.AreEqual((ulong)1, result1[0]);
            Assert.AreEqual((ulong)2, result1[1]);
            Assert.AreEqual((ulong)12, result2[0]);
            Assert.AreEqual((ulong)34, result2[1]);
            Assert.AreEqual((ulong)0, result2[2]);
            Assert.AreEqual((ulong)456, result2[3]);
        }
    }
}
