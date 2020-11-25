using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToOrDefault
    {
        [TestMethod]
        public void ToOrDefault()
        {
            object intValue = "1";
            object invalidValue = "Fizz";

            var result1 = intValue.ToOrDefault<int>();
            var result2 = invalidValue.ToOrDefault<int>();
            var result3 = invalidValue.ToOrDefault(3);
            var result4 = invalidValue.ToOrDefault(() => 4);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(4, result4);
        }
    }
}
