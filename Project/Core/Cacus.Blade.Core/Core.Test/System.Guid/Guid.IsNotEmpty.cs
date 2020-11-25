using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Guid
{
    [TestClass]
    public class SystemGuidIsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            var guidEmpty = global::System.Guid.Empty;
            var guidValue = global::System.Guid.NewGuid();

            Assert.IsFalse(guidEmpty.IsNotEmpty());
            Assert.IsTrue(guidValue.IsNotEmpty());
        }
    }
}
