using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractNumber
    {
        [TestMethod]
        public void ExtractNumber()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractNumber());
            Assert.AreEqual(null, new global::System.Text.StringBuilder(".").ExtractNumber());
            Assert.AreEqual("1", new global::System.Text.StringBuilder("1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new global::System.Text.StringBuilder(".1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new global::System.Text.StringBuilder(".1.1").ExtractNumber().ToString());
            Assert.AreEqual(".1D", new global::System.Text.StringBuilder(".1D").ExtractNumber().ToString());
            Assert.AreEqual(".1", new global::System.Text.StringBuilder("1.1").ExtractNumber(1).ToString());
            Assert.AreEqual(".1F", new global::System.Text.StringBuilder("1.1F1").ExtractNumber(1, out var endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}
