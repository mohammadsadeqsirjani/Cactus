using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringTruncate
    {
        [TestMethod]
        public void Truncate()
        {
            const string @this = "123456789";

            var result = @this.Truncate(6);

            Assert.AreEqual("123...", result);
        }
    }
}
