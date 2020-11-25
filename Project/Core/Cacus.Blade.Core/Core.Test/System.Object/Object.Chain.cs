using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectChain
    {
        [TestMethod]
        public void Chain()
        {
            var @this = new List<string>();

            @this.Chain(x => x.Add("Fizz"))
                .Chain(x => x.Add("Buzz"))
                .Chain(x => x.Add("FizzBuzz"));

            Assert.AreEqual(3, @this.Count);
        }
    }
}
