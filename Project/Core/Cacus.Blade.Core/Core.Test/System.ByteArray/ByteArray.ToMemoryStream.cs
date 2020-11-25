using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.ByteArray
{
    [TestClass]
    public class ByteArrayToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            var @this = new byte[1] { 1 };

            var result = @this.ToMemoryStream();

            Assert.AreEqual(1, result.ToArray()[0]);
        }
    }
}
