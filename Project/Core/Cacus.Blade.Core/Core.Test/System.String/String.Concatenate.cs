using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemTextStringBuilderConcatenate
    {
        [TestMethod]
        public void Concatenate()
        {
            var list = new List<string> { "Fizz", "Buzz" };

            var result1 = list.Concatenate();
            var result2 = list.Concatenate(x => x + x);

            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzFizzBuzzBuzz", result2);
        }
    }
}
