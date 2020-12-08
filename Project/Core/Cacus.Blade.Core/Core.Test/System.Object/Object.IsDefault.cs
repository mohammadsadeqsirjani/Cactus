using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsDefault
    {
        [TestMethod]
        public void IsDefault()
        {
            const int intDefault = 0;
            const int intNotDefault = 1;

            var result1 = intDefault.IsDefault();
            var result2 = intNotDefault.IsDefault();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
