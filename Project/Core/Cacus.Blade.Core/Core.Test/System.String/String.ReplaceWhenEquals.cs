using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringReplaceWhenEquals
    {
        [TestMethod]
        public void ReplaceExact()
        {
            const string @this = "Fizz";

            var result1 = @this.ReplaceWhenEquals("Fizz", "Buzz");
            var result2 = @this.ReplaceWhenEquals("Fiz", "Buzz");

            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}
