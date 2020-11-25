using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringLeft
    {
        [TestMethod]
        public void Left()
        {
            const string @this = "Fizz";

            var value = @this.Left(2);

            Assert.AreEqual("Fi", value);
        }
    }
}
