using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetEndOfDay
    {
        [TestMethod]
        public void EndOfDay()
        {
            var @this = global::System.DateTimeOffset.Now;

            var value = @this.EndOfDay();

            Assert.AreEqual(new global::System.DateTimeOffset(value.Year, value.Month, value.Day, 23, 59, 59, @this.Offset), value);
        }
    }
}
