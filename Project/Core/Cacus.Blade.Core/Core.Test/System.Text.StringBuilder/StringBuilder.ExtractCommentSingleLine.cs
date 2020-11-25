using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractCommentSingleLine
    {
        [TestMethod]
        public void ExtractCommentSingleLine()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractCommentSingleLine());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("//z").ExtractCommentSingleLine().ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z").ExtractCommentSingleLine(2).ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z" + global::System.Environment.NewLine + "z").ExtractCommentSingleLine(2, out var endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}
