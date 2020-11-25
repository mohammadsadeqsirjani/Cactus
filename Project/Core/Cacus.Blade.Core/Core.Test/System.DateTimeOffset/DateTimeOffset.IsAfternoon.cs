using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsAfternoon
    {
        [TestMethod]
        public void IsAfternoon()
        {
            var thisMorning = new global::System.DateTimeOffset(2014, 04, 12, 8, 0, 0, global::System. TimeSpan.Zero);
            var thisAfternoon = new global::System.DateTimeOffset(2014, 04, 12, 17, 0, 0, global::System. TimeSpan.Zero);

            var result1 = thisMorning.IsAfternoon();
            var result2 = thisAfternoon.IsAfternoon();

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}
