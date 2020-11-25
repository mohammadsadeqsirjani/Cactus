using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetStartOfMonth
    {
        [TestMethod]
        public void StartOfMonth()
        {
            var @this = global::System.DateTimeOffset.Now;

            var value = @this.StartOfMonth();

            Assert.AreEqual(new global::System.DateTimeOffset(value.Year, value.Month, 1, 0, 0, 0, value.Offset), value);
        }
    }
}
