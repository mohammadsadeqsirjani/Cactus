using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectAs
    {
        [TestMethod]
        public void As()
        {
            var intObject = (object)13;
            var stringObject = (object)"FizzBuzz";
            var arrayObject = (object)new[] { "Fizz", "Buzz" };

            var intValue = intObject.As<int>();
            var stringValue = stringObject.As<string>();
            var arrayCount = arrayObject.As<string[]>().Length;

            Assert.AreEqual(13, intValue);
            Assert.AreEqual("FizzBuzz", stringValue);
            Assert.AreEqual(2, arrayCount);
        }
    }
}
