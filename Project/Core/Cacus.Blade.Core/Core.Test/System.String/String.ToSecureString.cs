using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringToSecureString
    {
        [TestMethod]
        public void ToSecureString()
        {
            const string @this = "FizzBuzz";

            var result = @this.ToSecureString();
        }
    }
}
