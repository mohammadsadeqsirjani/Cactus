using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractString
    {
        [TestMethod]
        public void ExtractString()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringArobasDoubleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@\"z\"").ExtractStringArobasDoubleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@@\"z\"z").ExtractStringArobasDoubleQuote(1, out var endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringArobasSingleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@'z'").ExtractStringArobasSingleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("@@'z'z").ExtractStringArobasSingleQuote(1, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringDoubleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("\"z\"").ExtractStringDoubleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("-\"z\"z").ExtractStringDoubleQuote(1, out endIndex).ToString());
            Assert.AreEqual(4, endIndex);

            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringSingleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("'z'").ExtractStringSingleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("-'z'z").ExtractStringSingleQuote(1, out endIndex).ToString());
            Assert.AreEqual(4, endIndex);
        }
    }
}
