using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderExtractOperator
    {
        [TestMethod]
        public void ExtractOperator()
        {
            Assert.AreEqual(null, new global::System.Text.StringBuilder(" ").ExtractOperator());
            Assert.AreEqual(null, new global::System.Text.StringBuilder("a").ExtractOperator());
            Assert.AreEqual(null, new global::System.Text.StringBuilder("1").ExtractOperator());
            Assert.AreEqual(".", new global::System.Text.StringBuilder(".").ExtractOperator().ToString());
            Assert.AreEqual("..", new global::System.Text.StringBuilder("..").ExtractOperator().ToString());
            Assert.AreEqual(".", new global::System.Text.StringBuilder(". .").ExtractOperator().ToString());
            Assert.AreEqual("/*/", new global::System.Text.StringBuilder("//*/ z").ExtractOperator(1, out var endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}
