using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyUInt32
    {
        [TestMethod]
        public void ExtractManyUInt32()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyUInt32();
            var result2 = "12.34Fizz-0.456".ExtractManyUInt32();

            Assert.AreEqual((uint)1, result1[0]);
            Assert.AreEqual((uint)2, result1[1]);
            Assert.AreEqual((uint)12, result2[0]);
            Assert.AreEqual((uint)34, result2[1]);
            Assert.AreEqual((uint)0, result2[2]);
            Assert.AreEqual((uint)456, result2[3]);
        }
    }
}
