using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToStringSafe
    {
        [TestMethod]
        public void ToSafeString()
        {
            const int thisValue = 1;
            string @thisNull = null;

            var result1 = @thisValue.ToSafeString();
            var result2 = @thisNull.ToSafeString();

            Assert.AreEqual(result1, "1");
            Assert.AreEqual(result2, "");
        }
    }
}
