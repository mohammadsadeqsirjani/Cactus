using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractKeyword
    {
        [TestMethod]
        public void ExtractKeyword()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractKeyword());
            Assert.AreEqual(null, new global::System.Text.StringBuilder("1.1").ExtractKeyword());
            Assert.AreEqual(null, new global::System.Text.StringBuilder("@1a").ExtractKeyword());
            Assert.AreEqual("for", new global::System.Text.StringBuilder("for foreach").ExtractKeyword().ToString());
            Assert.AreEqual("@for", new global::System.Text.StringBuilder("zzz @for foreach").ExtractKeyword(4, out var endIndex).ToString());
            Assert.AreEqual(7, endIndex);
        }
    }
}
