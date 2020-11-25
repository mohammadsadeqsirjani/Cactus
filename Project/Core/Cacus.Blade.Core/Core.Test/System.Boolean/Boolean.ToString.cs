using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Boolean
{
    [TestClass]
    public class BooleanToString
    {
        [TestMethod]
        public void ToString()
        {
            const bool thisTrue = true;
            const bool thisFalse = false;

            var result1 = thisTrue.ToString("Fizz", "Buzz");
            var result2 = thisFalse.ToString("Fizz", "Buzz");

            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Buzz", result2);
        }
    }
}
