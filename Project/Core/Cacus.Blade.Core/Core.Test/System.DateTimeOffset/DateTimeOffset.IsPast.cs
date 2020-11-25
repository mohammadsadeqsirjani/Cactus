using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTimeOffset
{
    [TestClass]
    public class SystemDateTimeOffsetIsPast
    {
        [TestMethod]
        public void IsPast()
        {
            var @this = global::System.DateTimeOffset.Now.AddDays(1);

            var value1 = @this.IsPast();
            var value2 = @this.AddYears(-1).IsPast();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
