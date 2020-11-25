using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectNullIfEqualsAny
    {
        [TestMethod]
        public void NullIfEqualsAny()
        {
            object @this = "1";

            var result1 = @this.NullIfEqualsAny("0", "1", "2");
            var result2 = @this.NullIfEqualsAny("2");

            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}
