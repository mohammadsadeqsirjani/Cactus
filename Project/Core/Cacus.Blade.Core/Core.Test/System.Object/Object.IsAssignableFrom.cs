using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsAssignableFrom
    {
        [TestMethod]
        public void IsAssignableFrom()
        {
            var stringObject = (object)"FizzBuzz";

            var result1 = stringObject.IsAssignableFrom(typeof(string));
            var result2 = stringObject.IsAssignableFrom<string>();
            var result3 = stringObject.IsAssignableFrom<object>();
            var result4 = stringObject.IsAssignableFrom<int>();

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}
