using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringSplit
    {
        [TestMethod]
        public void Split()
        {
            const string @this = "FizzBuzz";

            var value = @this.Split("B");

            Assert.AreEqual("Fizz", value[0]);
            Assert.AreEqual("uzz", value[1]);
        }
    }
}
