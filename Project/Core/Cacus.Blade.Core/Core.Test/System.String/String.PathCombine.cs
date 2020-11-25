using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Core.Test.System.String
{
    [TestClass]
    public class SystemStringPathCombine
    {
        [TestMethod]
        public void PathCombine()
        {
            const string @this = "FizzBuzz";

            const string path1 = "Fizz";
            const string path2 = "Buzz";

            var result = @this.PathCombine(path1, path2);

            Assert.AreEqual(Path.Combine("FizzBuzz", path1, path2), result);
        }
    }
}
