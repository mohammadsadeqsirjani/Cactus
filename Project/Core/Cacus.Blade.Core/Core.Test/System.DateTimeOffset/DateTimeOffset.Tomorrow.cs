using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetTomorrow
    {
        [TestMethod]
        public void Tomorrow()
        {
            var @this = global::System.DateTimeOffset.Now;

            var result = @this.Tomorrow();

            Assert.AreEqual(@this.AddDays(1).Day, result.Day);
        }
    }
}
