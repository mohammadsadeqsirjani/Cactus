using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToNullableInt32
    {
        [TestMethod]
        public void ToNullableInt32()
        {
            object @this = null;
            object @thisValue = "32";

            var result1 = @this.ToNullableInt32();
            var result2 = @thisValue.ToNullableInt32();

            Assert.IsFalse(result1.HasValue);
            Assert.AreEqual(32, result2.Value);
        }
    }
}
