using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringEqualsIgnoreCase
    {
        [TestMethod]
        public void EqualsIgnoreCase()
        {
            const string @this = "FizBuzz";

            var value1 = @this.EqualsIgnoreCase("fizbuzz");
            var value2 = @this.EqualsIgnoreCase("FooBar");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
