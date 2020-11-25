using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetToEpochTimeSpan
    {
        [TestMethod]
        public void ToEpochTimeSpan()
        {
            var @this = global::System.DateTimeOffset.Now;

            var result = @this.ToEpochTimeSpan();

            Assert.AreEqual(@this.Subtract(new global::System.DateTimeOffset(1970, 1, 1, 0, 0, 0, @this.Offset)).TotalMilliseconds, result.TotalMilliseconds);
        }
    }
}
