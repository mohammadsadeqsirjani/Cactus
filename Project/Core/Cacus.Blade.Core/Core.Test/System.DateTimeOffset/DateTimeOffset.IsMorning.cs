using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsMorning
    {
        [TestMethod]
        public void IsMorning()
        {
            var thisMorning = new global::System.DateTimeOffset(2014, 04, 12, 8, 0, 0, global::System. TimeSpan.Zero);
            var thisAfternoon = new global::System.DateTimeOffset(2014, 04, 12, 17, 0, 0, global::System. TimeSpan.Zero);

            var result1 = thisMorning.IsMorning();
            var result2 = thisAfternoon.IsMorning();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
