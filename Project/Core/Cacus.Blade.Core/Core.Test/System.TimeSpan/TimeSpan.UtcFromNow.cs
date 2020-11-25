using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.TimeSpan
{
    [TestClass]
    public class SystemTimeSpanUtcFromNow
    {
        [TestMethod]
        public void UtcFromNow()
        {
            var @this = new global::System.TimeSpan(1, 0, 0, 0);

            var value = @this.UtcFromNow();

            Assert.IsTrue(global::System.DateTime.UtcNow.Subtract(value).Days > -1);
        }
    }
}
