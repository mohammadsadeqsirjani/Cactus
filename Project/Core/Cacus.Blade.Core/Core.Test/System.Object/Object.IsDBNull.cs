using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectIsDbNull
    {
        [TestMethod]
        public void IsDbNull()
        {
            object @thisDBNull = DBNull.Value;
            object @thisNull = null;

            var result1 = @thisDBNull.IsDbNull();
            var result2 = @thisNull.IsDbNull();

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
