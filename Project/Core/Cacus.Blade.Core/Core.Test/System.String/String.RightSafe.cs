using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRightSafe
    {
        [TestMethod]
        public void RightSafe()
        {
            const string @this = "Fizz";

            var result1 = @this.SafeRight(2);
            var result2 = @this.SafeRight(int.MaxValue);

            Assert.AreEqual("zz", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}
