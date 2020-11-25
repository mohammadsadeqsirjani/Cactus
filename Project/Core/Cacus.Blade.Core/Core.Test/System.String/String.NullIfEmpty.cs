using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringNullIfEmpty
    {
        [TestMethod]
        public void NullIfEmpty()
        {
            const string @this = "";

            var value = @this.NullIfEmpty();

            Assert.IsNull(value);
        }
    }
}
