using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            const string @this = "FizzBuzz";

            using var value = @this.ToMemoryStream();

            Assert.IsNotNull(value);
        }
    }
}
