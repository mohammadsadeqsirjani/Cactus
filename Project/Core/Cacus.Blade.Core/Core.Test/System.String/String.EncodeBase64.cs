using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringEncodeBase64
    {
        [TestMethod]
        public void EncodeBase64()
        {
            const string @this = "Rml6eg==";

            var value = @this.DecodeBase64();

            Assert.AreEqual("Fizz", value);
        }
    }
}
