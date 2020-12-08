using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToEnum
    {
        [TestMethod]
        public void ToEnum()
        {
            const string @this = "Ordinal";

            var value = @this.ToEnum<StringComparison>();

            Assert.AreEqual(StringComparison.Ordinal, value);
        }
    }
}
