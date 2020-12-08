using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractCommentMultiLine
    {
        [TestMethod]
        public void ExtractCommentMultiLine()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractCommentMultiLine());
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*z").ExtractCommentMultiLine().ToString());
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*/*z").ExtractCommentMultiLine(2).ToString());
            Assert.AreEqual("/*z*/", new global::System.Text.StringBuilder("/**//*z*/").ExtractCommentMultiLine(4, out var endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}
