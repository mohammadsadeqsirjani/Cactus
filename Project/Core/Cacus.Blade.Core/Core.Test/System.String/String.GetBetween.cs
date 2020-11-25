using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringGetBetween
    {
        [TestMethod]
        public void GetBetween()
        {
            const string @this = "Fizz";

            var result1 = @this.GetBetween("F", "z");
            var result2 = @this.GetBetween("a", "b");

            Assert.AreEqual("i", result1);
            Assert.AreEqual("", result2);
        }
    }
}
