using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringContains
    {
        [TestMethod]
        public void Contains()
        {
            const string @this = "Fizz";

            var value1 = @this.Contains("f", StringComparison.InvariantCultureIgnoreCase);
            var value2 = @this.Contains("f", StringComparison.InvariantCulture);
            var value3 = @this.Contains("F");

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
        }
    }
}
