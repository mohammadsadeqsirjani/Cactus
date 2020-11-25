using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsNow
    {
        [TestMethod]
        public void IsNow()
        {
            var @this = global::System.DateTimeOffset.Now;

            var value1 = @this.IsNow();
        }
    }
}
