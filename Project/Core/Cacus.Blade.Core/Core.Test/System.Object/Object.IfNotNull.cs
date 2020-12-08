using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIfNotNull
    {
        [TestMethod]
        public void IfNotNull()
        {
            var values = new List<string> { "Fizz", "Buzz" };
            List<string> valuesNull = null;
            string actionOutput1 = null;
            string actionOutput2 = null;

            var result1 = values.IfNotNull(x => x.First(), "FizzBuzz");
            var result2 = valuesNull.IfNotNull(x => x.First(), "FizzBuzz");
            var result3 = valuesNull.IfNotNull(x => x.First(), () => "FizzBuzz");

            values.IfNotNull(x => actionOutput1 = string.Join("", values));
            valuesNull.IfNotNull(x => actionOutput2 = string.Join("", values));

            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("FizzBuzz", result2);
            Assert.AreEqual("FizzBuzz", result3);

            Assert.AreEqual("FizzBuzz", actionOutput1);
            Assert.IsNull(actionOutput2);
        }
    }
}
