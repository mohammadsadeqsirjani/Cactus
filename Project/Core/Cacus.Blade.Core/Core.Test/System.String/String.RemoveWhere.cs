using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRemoveWhere
    {
        [TestMethod]
        public void RemoveWhere()
        {
            const string @this = "Fizz1Buzz2";

            var result = @this.RemoveWhere(c => c.IsNumber());

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
