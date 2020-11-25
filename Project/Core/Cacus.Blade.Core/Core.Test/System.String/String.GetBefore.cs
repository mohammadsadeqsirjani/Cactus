using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringGetBefore
    {
        [TestMethod]
        public void GetBefore()
        {
            const string @this = "Fizz";

            var result1 = @this.GetBefore("i");
            var result2 = @this.GetBefore("a");

            Assert.AreEqual("F", result1);
            Assert.AreEqual("", result2);
        }
    }
}
