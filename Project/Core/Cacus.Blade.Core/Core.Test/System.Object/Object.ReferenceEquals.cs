using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectReferenceEquals
    {
        [TestMethod]
        public void ReferenceEquals()
        {
            string @this = null;

            var result1 = @this.ReferenceEquals(null);
            var result2 = @this.ReferenceEquals("");

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
