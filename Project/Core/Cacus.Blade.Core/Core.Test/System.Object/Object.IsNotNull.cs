using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsNotNull
    {
        [TestMethod]
        public void IsNotNull()
        {
            object @thisNull = null;
            var @thisNotNull = new object();

            var value1 = @thisNull.IsNotNull();
            var value2 = @thisNotNull.IsNotNull();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}
