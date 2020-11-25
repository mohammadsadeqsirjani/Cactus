using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectNullIf
    {
        [TestMethod]
        public void NullIf()
        {
            const string @this = "1";

            var result1 = @this.NullIf(x => x == "1");
            var result2 = @this.NullIf(x => x == "2");

            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}
