using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Boolean
{
    [TestClass]
    public class BooleanToBinary
    {
        [TestMethod]
        public void ToBinary()
        {
            const bool thisTrue = true;
            const bool thisFalse = false;

            var result1 = thisTrue.ToBinary();
            var result2 = thisFalse.ToBinary();

            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
        }
    }
}
