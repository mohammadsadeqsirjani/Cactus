using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetEndOfYear
    {
        [TestMethod]
        public void EndOfYear()
        {
            var @this = new global::System.DateTimeOffset(2013, 04, 13, 23, 59, 59, global::System.TimeSpan.Zero);

            var value = @this.EndOfYear();

            Assert.AreEqual(new global::System.DateTimeOffset(2013, 12, 31, 23, 59, 59, global::System.TimeSpan.Zero), value);
        }
    }
}
