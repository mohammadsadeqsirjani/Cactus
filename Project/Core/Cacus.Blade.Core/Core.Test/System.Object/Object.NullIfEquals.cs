using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectNullIfEquals
    {
        [TestMethod]
        public void NullIfEquals()
        {
            object @this = "1";

            var result1 = @this.NullIfEquals("1");
            var result2 = @this.NullIfEquals("2");

            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}
