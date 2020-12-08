using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToByteArray
    {
        [TestMethod]
        public void ToByteArray()
        {
            const string @this = "Fizz";

            var value = @this.ToByteArray();

            Assert.AreEqual(4, value.Length);
        }
    }
}
