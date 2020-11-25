using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetEndOfMonth
    {
        [TestMethod]
        public void EndOfMonth()
        {
            var @this = new global::System.DateTimeOffset(2013, 12, 22, 23, 59, 59, global::System.TimeSpan.Zero);

            var value = @this.EndOfMonth();

            Assert.AreEqual(new global::System.DateTimeOffset(2013, 12, 31, 23, 59, 59, global::System.TimeSpan.Zero), value);
        }
    }
}
