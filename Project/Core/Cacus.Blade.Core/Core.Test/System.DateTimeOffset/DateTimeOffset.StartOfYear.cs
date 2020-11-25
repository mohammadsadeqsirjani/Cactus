using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetStartOfYear
    {
        [TestMethod]
        public void StartOfYear()
        {
            var @this = global::System.DateTimeOffset.Now;

            var value = @this.StartOfYear();

            Assert.AreEqual(new global::System.DateTimeOffset(value.Year, 1, 1, 0, 0, 0, value.Offset), value);
        }
    }
}
