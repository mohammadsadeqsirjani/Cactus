using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIn
    {
        [TestMethod]
        public void In()
        {
            var @this = "a";

            var value1 = @this.In("a", "1", "2", "3");
            var value2 = @this.In("1", "2", "3");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
