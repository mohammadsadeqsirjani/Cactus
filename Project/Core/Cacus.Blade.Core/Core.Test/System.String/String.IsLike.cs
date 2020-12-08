using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsLike
    {
        [TestMethod]
        public void IsLike()
        {
            const string @this = "FizzBuzz3";

            var value1 = @this.IsLike("Fizz*");
            var value2 = @this.IsLike("*zzB*");
            var value3 = @this.IsLike("*Buzz#");
            var value4 = @this.IsLike("*zz?u*");

            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsTrue(value4);
        }
    }
}
