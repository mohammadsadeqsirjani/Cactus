using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRight
    {
        [TestMethod]
        public void Right()
        {
            const string @this = "Fizz";

            var value = @this.Right(2);

            Assert.AreEqual("zz", value);
        }
    }
}
