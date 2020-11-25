using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectAsOrDefault
    {
        [TestMethod]
        public void AsOrDefault()
        {
            object intValue = 1;
            object invalidValue = "Fizz";

            var result1 = intValue.AsOrDefault<int>();
            var result2 = invalidValue.AsOrDefault<int>();
            var result3 = invalidValue.AsOrDefault(3);
            var result4 = invalidValue.AsOrDefault(() => 4);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(4, result4);
        }
    }
}
