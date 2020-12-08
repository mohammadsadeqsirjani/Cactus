using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetFirstDayOfWeek
    {
        [TestMethod]
        public void FirstDayOfWeek()
        {
            var @this = new global::System.DateTimeOffset(2014, 04, 16, 0, 0, 0, global::System. TimeSpan.Zero);

            var result = @this.FirstDayOfWeek();

            Assert.AreEqual(new global::System.DateTimeOffset(2014, 04, 13, 0, 0, 0, global::System. TimeSpan.Zero), result);
        }
    }
}
