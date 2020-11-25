using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToInt32
    {
        [TestMethod]
        public void ToInt32()
        {
            const string @this = "32";

            var result = @this.ToInt32();

            Assert.AreEqual(32, result);
        }
    }
}
