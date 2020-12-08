using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            const string @this = "Fizz";

            var value1 = @this.ContainsAny("F", "Buzz");
            var value2 = @this.ContainsAny("Bizz", "Buzz");
            var value3 = @this.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "f", "Buzz");
            var value4 = @this.ContainsAny(StringComparison.InvariantCulture, "f", "Buzz");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}
