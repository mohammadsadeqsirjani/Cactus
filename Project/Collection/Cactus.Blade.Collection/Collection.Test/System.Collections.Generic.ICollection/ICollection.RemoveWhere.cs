using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collection.Test.System.Collections.Generic.ICollection
{
    [TestClass]
    public class CollectionRemoveWhere
    {
        [TestMethod]
        public void RemoveWhere()
        {
            var @this = new List<string> { "zA", "zB", "C" };

            @this.RemoveWhere(x => x.StartsWith("z"));

            Assert.AreEqual(1, @this.Count);
        }
    }
}
