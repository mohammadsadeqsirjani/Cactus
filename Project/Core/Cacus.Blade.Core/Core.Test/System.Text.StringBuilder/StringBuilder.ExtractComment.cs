using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractComment
    {
        [TestMethod]
        public void ExtractComment()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractComment());
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*z").ExtractComment().ToString());
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*/*z").ExtractComment(2).ToString());
            Assert.AreEqual("/*z*/", new global::System.Text.StringBuilder("/**//*z*/").ExtractComment(4, out var endIndex).ToString());
            Assert.AreEqual(8, endIndex);

            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractComment());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("//z").ExtractComment().ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z").ExtractComment(2).ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z" + global::System.Environment.NewLine + "z").ExtractComment(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}
