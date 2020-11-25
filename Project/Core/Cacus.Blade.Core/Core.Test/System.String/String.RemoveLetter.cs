using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRemoveLetter
    {
        [TestMethod]
        public void RemoveLetter()
        {
            const string @this = "Fizz1Buzz2";

            var result = @this.RemoveLetter();

            Assert.AreEqual("12", result);
        }
    }
}
