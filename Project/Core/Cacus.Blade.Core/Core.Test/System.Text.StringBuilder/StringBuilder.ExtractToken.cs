using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractToken
    {
        [TestMethod]
        public void ExtractToken()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractToken());
            Assert.AreEqual("123.4LU", new global::System.Text.StringBuilder("123.4LU foreach").ExtractToken().ToString());
            Assert.AreEqual("for", new global::System.Text.StringBuilder("for foreach").ExtractToken().ToString());
            Assert.AreEqual("custom", new global::System.Text.StringBuilder("custom foreach").ExtractToken().ToString());
            Assert.AreEqual("+=", new global::System.Text.StringBuilder("z += 2").ExtractToken(2, out var endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}
