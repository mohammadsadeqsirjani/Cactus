using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractChar
    {
        [TestMethod]
        public void ExtractChar()
        {
            Assert.AreEqual('a', new global::System.Text.StringBuilder("'a'").ExtractChar());
            Assert.AreEqual('\'', new global::System.Text.StringBuilder("'\''").ExtractChar());
            Assert.AreEqual('\'', new global::System.Text.StringBuilder("z'\''").ExtractChar(1, out var endIndex));
            Assert.AreEqual(3, endIndex);

            try
            {
                new global::System.Text.StringBuilder("'").ExtractChar();
                throw new Exception("invalid!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid char at position: 0", ex.Message);
            }
        }
    }
}
