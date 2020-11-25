using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectInRange
    {
        [TestMethod]
        public void InRange()
        {
            var @this = 3;

            var value1 = @this.InRange(-4, 3);
            var value2 = @this.InRange(10, 100);

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
