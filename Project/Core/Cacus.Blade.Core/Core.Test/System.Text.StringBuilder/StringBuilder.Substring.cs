using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Text.StringBuilder
{
    [TestClass]
    public class SystemTextStringBuilderSubstring
    {
        [TestMethod]
        public void Substring()
        {
            var @this = new global::System.Text.StringBuilder("0123456789");

            var result1 = @this.Substring(4);
            var result2 = @this.Substring(4, 2);

            Assert.AreEqual("456789", result1);
            Assert.AreEqual("45", result2);
        }
    }
}
