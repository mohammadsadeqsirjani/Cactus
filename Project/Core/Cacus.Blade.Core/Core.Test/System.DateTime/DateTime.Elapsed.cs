using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeElapsed
    {
        [TestMethod]
        public void Elapsed()
        {
            var @this = global::System.DateTime.Now;

            var result = @this.Elapsed();

            // UnitTest
        }
    }
}
