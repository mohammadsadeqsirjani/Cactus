using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringConcatWith
    {
        [TestMethod]
        public void ConcatWith()
        {
            const string @this = "Fizz";

            var result = @this.ConcatWith("Buzz", "FizzBuzz");

            Assert.AreEqual("FizzBuzzFizzBuzz", result);
        }
    }
}
