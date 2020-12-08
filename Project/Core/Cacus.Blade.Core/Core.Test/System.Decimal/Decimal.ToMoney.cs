using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Decimal
{
    [TestClass]
    public class SystemDecimalToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            const decimal this1 = 2.311M;
            const decimal this2 = 2.3191M;

            var result1 = this1.ToMoney();
            var result2 = this2.ToMoney();

            Assert.AreEqual(2.31M, result1);
            Assert.AreEqual(2.32M, result2);
        }
    }
}
