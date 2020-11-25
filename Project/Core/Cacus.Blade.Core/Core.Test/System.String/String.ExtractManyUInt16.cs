using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringExtractManyUInt16
    {
        [TestMethod]
        public void ExtractManyUInt16()
        {
            var result1 = "1Fizz-2Buzz".ExtractManyUInt16();
            var result2 = "12.34Fizz-0.456".ExtractManyUInt16();

            Assert.AreEqual((ushort)1, result1[0]);
            Assert.AreEqual((ushort)2, result1[1]);
            Assert.AreEqual((ushort)12, result2[0]);
            Assert.AreEqual((ushort)34, result2[1]);
            Assert.AreEqual((ushort)0, result2[2]);
            Assert.AreEqual((ushort)456, result2[3]);
        }
    }
}
