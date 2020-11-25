using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetStartOfWeek
    {
        [TestMethod]
        public void StartOfWeek()
        {
            var @this = new global::System.DateTimeOffset(2014, 04, 16, 0, 0, 0, TimeSpan.Zero);

            var value = @this.StartOfWeek();

            Assert.AreEqual(new global::System.DateTimeOffset(2014, 04, 13, 0, 0, 0, value.Offset), value);
        }
    }
}
