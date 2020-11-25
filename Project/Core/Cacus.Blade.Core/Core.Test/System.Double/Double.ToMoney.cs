using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Double
{
    [TestClass]
    public class SystemDoubleToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            const double this1 = 2.311;
            const double this2 = 2.3191;

            var result1 = this1.ToMoney();
            var result2 = this2.ToMoney();

            Assert.AreEqual(2.31, result1);
            Assert.AreEqual(2.32, result2);
        }
    }
}
