using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectBetween
    {
        [TestMethod]
        public void Between()
        {
            const int @this = 3;

            var result1 = @this.Between(1, 4);
            var result2 = @this.Between(1, 3);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
