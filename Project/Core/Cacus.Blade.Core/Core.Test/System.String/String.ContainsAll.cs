using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringContainsAll
    {
        [TestMethod]
        public void ContainsAll()
        {
            const string @this = "Fizz";

            var value1 = @this.ContainsAll("F", "i");
            var value2 = @this.ContainsAll("F", "i", "Buzz");
            var value3 = @this.ContainsAll(StringComparison.InvariantCultureIgnoreCase, "f", "i");
            var value4 = @this.ContainsAll(StringComparison.InvariantCulture, "f", "i");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}
