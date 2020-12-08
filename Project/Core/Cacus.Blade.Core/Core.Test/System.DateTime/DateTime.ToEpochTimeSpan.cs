using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeToEpochTimeSpan
    {
        [TestMethod]
        public void ToEpochTimeSpan()
        {
            var @this = global::System.DateTime.Now;

            var result = @this.ToEpochTimeSpan();

            Assert.AreEqual(@this.Subtract(new global::System.DateTime(1970, 1, 1)).TotalMilliseconds, result.TotalMilliseconds);
        }
    }
}
