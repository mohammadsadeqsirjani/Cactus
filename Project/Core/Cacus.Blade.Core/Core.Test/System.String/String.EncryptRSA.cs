using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringEncryptRsa
    {
        [TestMethod]
        public void EncryptRsa()
        {
            const string @this = "Fizz";

            var value = @this.EncryptRsa("Buzz");

            Assert.AreEqual("Fizz", value.DecryptRsa("Buzz"));
        }
    }
}
