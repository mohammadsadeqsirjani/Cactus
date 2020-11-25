using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringFormatWith
    {
        [TestMethod]
        public void FormatWith()
        {
            const string @this = "{0}{1}";

            var value = @this.FormatWith("Fizz", "Buzz");

            Assert.AreEqual("FizzBuzz", value);
        }
    }
}
