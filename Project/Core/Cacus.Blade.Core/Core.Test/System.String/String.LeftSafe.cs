using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringLeftSafe
    {
        [TestMethod]
        public void LeftSafe()
        {
            const string @this = "Fizz";

            var result1 = @this.SafeLeft(2);
            var result2 = @this.SafeLeft(int.MaxValue);

            Assert.AreEqual("Fi", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}
