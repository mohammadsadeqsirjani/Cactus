using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class DateTimeOffsetAge
    {
        [TestMethod]
        public void Age()
        {
            var @this = new global::System.DateTimeOffset(1981, 01, 01, 0, 0, 0, global::System.TimeSpan.Zero);

            var result = @this.Age();

            Assert.AreEqual(global::System.DateTimeOffset.Now.Year - 1981, result);
        }
    }
}
