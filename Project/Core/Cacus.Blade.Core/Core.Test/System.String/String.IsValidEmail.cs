using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringIsValidEmail
    {
        [TestMethod]
        public void IsValidEmail()
        {
            {
                const string @this = "test@hotmail.com";

                var result = @this.IsValidEmail();

                Assert.IsTrue(result);
            }

            {
                const string @this = "mike@GOTBLOG.ONLINE";

                var result = @this.IsValidEmail();

                Assert.IsTrue(result);
            }
        }
    }
}
