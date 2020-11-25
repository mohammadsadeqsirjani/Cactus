using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractStringArobasDoubleQuote
    {
        [TestMethod]
        public void ExtractStringArobasDoubleQuote()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringArobasDoubleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@\"z\"").ExtractStringArobasDoubleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@@\"z\"z").ExtractStringArobasDoubleQuote(1, out var endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}
