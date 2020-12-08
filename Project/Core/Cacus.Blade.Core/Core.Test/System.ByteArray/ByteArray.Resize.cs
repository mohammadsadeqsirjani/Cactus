using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.ByteArray
{
    [TestClass]
    public class ByteArrayResize
    {
        [TestMethod]
        public void Resize()
        {
            var @this = new byte[1];

            @this[0] = 1;

            @this = @this.Resize(4);

            Assert.AreEqual(1, @this[0]);
            Assert.AreEqual(4, @this.Length);
        }
    }
}
