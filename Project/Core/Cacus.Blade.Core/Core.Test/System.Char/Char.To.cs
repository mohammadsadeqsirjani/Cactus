using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Core.Test.System.Char
{
    [TestClass]
    public class CharTo
    {
        [TestMethod]
        public void To()
        {
            const char @this = 'A';

            var list = @this.To('C').ToList();

            Assert.AreEqual(3, list.Count);
        }
    }
}
