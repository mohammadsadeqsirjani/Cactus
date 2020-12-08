using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetElapsed
    {
        [TestMethod]
        public void Elapsed()
        {
            var @this = global::System.DateTimeOffset.Now;

            var result = @this.Elapsed();

            // UnitTest
        }
    }
}
