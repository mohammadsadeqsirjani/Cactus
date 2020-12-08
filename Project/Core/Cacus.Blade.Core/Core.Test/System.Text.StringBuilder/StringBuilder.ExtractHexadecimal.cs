using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractHexadecimal
    {
        [TestMethod]
        public void ExtractHexadecimal()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractHexadecimal());
            Assert.AreEqual("0x2A", new global::System.Text.StringBuilder("0x2A").ExtractHexadecimal().ToString());
            Assert.AreEqual("0x2A", new global::System.Text.StringBuilder("0x0x2A").ExtractHexadecimal(2).ToString());
            Assert.AreEqual("0x2FUL", new global::System.Text.StringBuilder("0x0x2FUL").ExtractHexadecimal(2, out var endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}
