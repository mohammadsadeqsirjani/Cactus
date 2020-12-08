using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Guid
{
    [TestClass]
    public class SystemGuidIsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            var guidEmpty = global::System.Guid.Empty;
            var guidValue = global::System.Guid.NewGuid();

            Assert.IsTrue(guidEmpty.IsEmpty());
            Assert.IsFalse(guidValue.IsEmpty());
        }
    }
}
