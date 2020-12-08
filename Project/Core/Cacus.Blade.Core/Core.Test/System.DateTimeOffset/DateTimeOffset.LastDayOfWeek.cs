using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetLastDayOfWeek
    {
        [TestMethod]
        public void LastDayOfWeek()
        {
            var @this = new global::System.DateTimeOffset(2014, 01, 24, 0, 0, 0, global::System.TimeSpan.Zero);

            var result = @this.LastDayOfWeek();

            Assert.AreEqual(new global::System.DateTimeOffset(2014, 01, 25, 0, 0, 0, global::System.TimeSpan.Zero), result);
        }
    }
}
