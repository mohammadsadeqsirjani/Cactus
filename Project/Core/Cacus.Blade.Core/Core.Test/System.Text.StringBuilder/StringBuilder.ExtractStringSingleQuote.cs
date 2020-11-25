using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractStringSingleQuote
    {
        [TestMethod]
        public void ExtractStringSingleQuote()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractStringSingleQuote());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("'z'").ExtractStringSingleQuote().ToString());
            Assert.AreEqual("z", new global::System.Text.StringBuilder("-'z'z").ExtractStringSingleQuote(1, out var endIndex).ToString());
            Assert.AreEqual(4, endIndex);
        }
    }
}
