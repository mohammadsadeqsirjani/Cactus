using Core.System.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectShallowCopy
    {
        [TestMethod]
        public void ShallowCopy()
        {
            var @this = new TestClass { Value = "Fizz" };

            var clone = @this.ShallowCopy();

            Assert.AreEqual(@this.Value, clone.Value);
        }

        [Serializable]
        public class TestClass
        {
            public string Value;
        }
    }
}
