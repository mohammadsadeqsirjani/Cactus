using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetStartOfDay
    {
        [TestMethod]
        public void StartOfDay()
        {
            var @this = global::System.DateTimeOffset.Now;

            var value = @this.StartOfDay();

            Assert.AreEqual(new global::System.DateTimeOffset(value.Year, value.Month, value.Day, 0, 0, 0, @this.Offset), value);
        }
    }
}
