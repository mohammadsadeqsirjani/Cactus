using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsNull
    {
        [TestMethod]
        public void IsNull()
        {
            object @thisNull = null;
            var @thisNotNull = new object();

            var value1 = @thisNull.IsNull();
            var value2 = @thisNotNull.IsNull();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}
