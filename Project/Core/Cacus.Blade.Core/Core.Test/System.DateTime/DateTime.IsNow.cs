using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.DateTime
{
    [TestClass]
    public class SystemDateTimeIsNow
    {
        [TestMethod]
        public void IsNow()
        {
            var @this = global::System.DateTime.Now;

            var value1 = @this.IsNow();
        }
    }
}
