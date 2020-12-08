using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectTry
    {
        [TestMethod]
        public void Try()
        {
            var list = new List<int> { 1 };

            var result1 = list.Try(x => x[0]);
            var result2 = list.Try(x => x[1]);
            var result3 = list.Try(x => x[1], -1);
            var result7 = list.Try(x => x[0], out var result10);
            var result8 = list.Try(x => x[1], out var result11);
            var result9 = list.Try(x => x[1], -1, out var result12);
            var result4 = list.Try(x => x[1], its => -2);
            var result5 = list.Try(x => x.Add(2));
            var result6 = list.Try(x => throw new Exception("exception!"), x => x.Add(3));

            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
            Assert.AreEqual(3, list.Count);
            Assert.IsTrue(result7);
            Assert.IsFalse(result8);
            Assert.IsFalse(result9);
            Assert.AreEqual(1, result10);
            Assert.AreEqual(0, result11);
            Assert.AreEqual(-1, result12);
        }
    }
}
