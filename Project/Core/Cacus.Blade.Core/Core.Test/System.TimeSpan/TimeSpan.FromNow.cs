using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.TimeSpan
{
    [TestClass]
    public class SystemTimeSpanFromNow
    {
        [TestMethod]
        public void FromNow()
        {
            var @this = new global::System.TimeSpan(1, 0, 0, 0);

            var value = @this.FromNow();

            Assert.IsTrue(global::System.DateTime.Now.Subtract(value).Days > -1);
        }
    }
}
