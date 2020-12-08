using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsValidInt32
    {
        [TestMethod]
        public void IsValidInt32()
        {
            object nullValue = null;
            var result1 = nullValue.IsValidInt32();
            var result2 = "12345".IsValidInt32();
            var result3 = "1.32".IsValidInt32();
            var result4 = "ABC".IsValidInt32();

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}
