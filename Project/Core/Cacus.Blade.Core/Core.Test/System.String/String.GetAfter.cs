using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringGetAfter
    {
        [TestMethod]
        public void GetAfter()
        {
            const string @this = "Fizz";

            var result1 = @this.GetAfter("i");
            var result2 = @this.GetAfter("a");

            Assert.AreEqual("zz", result1);
            Assert.AreEqual("", result2);
        }
    }
}
