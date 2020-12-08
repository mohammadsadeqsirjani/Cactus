using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectTo
    {
        [TestMethod]
        public void To()
        {
            string nullValue = null;
            const string value = "1";
            object dbNullValue = DBNull.Value;

            var result1 = value.To<int>();
            var result2 = value.To<int?>();
            var result3 = nullValue.To<int?>();
            var result4 = dbNullValue.To<int?>();

            Assert.AreEqual(1, result1);
            Assert.AreEqual(1, result2.Value);
            Assert.IsFalse(result3.HasValue);
            Assert.IsFalse(result4.HasValue);
        }
    }
}
