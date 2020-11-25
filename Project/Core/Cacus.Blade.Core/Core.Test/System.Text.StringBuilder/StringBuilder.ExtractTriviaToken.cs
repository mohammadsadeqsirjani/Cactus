using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractTriviaToken
    {
        [TestMethod]
        public void ExtractTriviaToken()
        {
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*z").ExtractTriviaToken().ToString());
            Assert.AreEqual("/*z", new global::System.Text.StringBuilder("/*/*z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("/*z*/", new global::System.Text.StringBuilder("/**//*z*/").ExtractTriviaToken(4, out var endIndex).ToString());
            Assert.AreEqual(8, endIndex);

            Assert.AreEqual("//z", new global::System.Text.StringBuilder("//z").ExtractTriviaToken().ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("//z", new global::System.Text.StringBuilder("////z" + global::System.Environment.NewLine + "z").ExtractTriviaToken(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            Assert.AreEqual("  ", new global::System.Text.StringBuilder("   z").ExtractTriviaToken(1, out endIndex).ToString());
            Assert.AreEqual(2, endIndex);
        }
    }
}
