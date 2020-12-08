using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.TimeSpan
{
    [TestClass]
    public class SystemTimeSpanUtcAgo
    {
        [TestMethod]
        public void UtcAgo()
        {
            var @this = new global::System.TimeSpan(1, 0, 0, 0);

            var value = @this.UtcAgo();

            Assert.IsTrue(global::System.DateTime.UtcNow.Subtract(value).Days >= 1);
        }
    }
}
