using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectNotIn
    {
        [TestMethod]
        public void NotIn()
        {
            const string @this = "a";

            var value1 = @this.NotIn("1", "2", "3");
            var value2 = @this.NotIn("a", "1", "2", "3");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
