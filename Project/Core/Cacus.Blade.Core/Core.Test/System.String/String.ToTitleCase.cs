using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToTitleCase
    {
        [TestMethod]
        public void ToTitleCase()
        {
            const string @this = "fizz buzz";

            var result = @this.ToTitleCase();

            Assert.AreEqual("Fizz Buzz", result);
        }
    }
}
