using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRemoveNumber
    {
        [TestMethod]
        public void RemoveNumber()
        {
            const string @this = "Fizz1Buzz2";

            var result = @this.RemoveNumber();

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
