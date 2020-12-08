using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringRemoveDiacritics
    {
        [TestMethod]
        public void RemoveDiacritics()
        {
            const string @this = "éèêôîâ";

            var value = @this.RemoveDiacritics();

            Assert.AreEqual("eeeoia", value);
        }
    }
}
