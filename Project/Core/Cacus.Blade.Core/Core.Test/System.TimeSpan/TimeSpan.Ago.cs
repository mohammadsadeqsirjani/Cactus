using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.TimeSpan
{
    [TestClass]
    public class SystemTimeSpanAgo
    {
        [TestMethod]
        public void Ago()
        {
            var @this = new global::System.TimeSpan(1, 0, 0, 0);

            var value = @this.Ago(); // return yesterday.

            Assert.IsTrue(global::System.DateTime.Now.Subtract(value).Days >= 1);
        }
    }
}
