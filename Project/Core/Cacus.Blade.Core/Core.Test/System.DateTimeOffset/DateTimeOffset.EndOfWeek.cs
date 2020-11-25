using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetEndOfWeek
    {
        [TestMethod]
        public void EndOfWeek()
        {
            var @this = new global::System.DateTimeOffset(2014, 04, 16, 23, 59, 59, TimeSpan.Zero);

            var value = @this.EndOfWeek();

            Assert.AreEqual(new global::System.DateTimeOffset(2014, 04, 19, 23, 59, 59, TimeSpan.Zero), value);
        }
    }
}
