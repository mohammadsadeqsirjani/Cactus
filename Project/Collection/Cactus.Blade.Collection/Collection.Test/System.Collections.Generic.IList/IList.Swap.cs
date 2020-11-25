using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection.Test.System.Collections.Generic.IList
{
    [TestClass]
    public class ListSwap
    {
        [TestMethod]
        public void Swap()
        {
            var stringList = new List<string>() { "Foo", "Bar", "Baz" };
            var obj1 = new { Id = 1, Message = "Foo" };
            var obj2 = new { Id = 2, Message = "Bar" };
            var obj3 = new { Id = 3, Message = "Baz" };

            var example1 = new List<string>(stringList);
            var example2 = new List<string>(stringList);
            var example3 = new List<string>(stringList);
            var example4 = new List<string>(stringList);
            var example5 = new List<string>() { "Foo", "Bar", "Bar" };
            var example6 = new List<object>() { obj1, obj2 };

            example1.Swap("Baz", "NewBaz");
            example2.Swap("NoValueFound", "NoBaz");
            example3.Swap(null, "NothingChanged");
            example4.Swap("Bar", "NewBar");
            example5.Swap("Bar", "Baz");
            example6.Swap(obj2, obj3);

            var result1 = new List<string>() { "Foo", "Bar", "NewBaz" };
            var result2 = new List<string>(stringList);
            var result3 = new List<string>(stringList);
            var result4 = example4.ElementAt(1).Equals("NewBar");
            var result5 = example5.Contains("Bar");
            var result6 = example6.Contains(obj3);

            Assert.IsTrue(example1.Contains("NewBaz"), "The collection should contain this value");
            Assert.IsFalse(example2.Contains("NoBaz"), "The collection shouldn't contain this value");
            Assert.IsTrue(example1.SequenceEqual(result1), "The collection should have the replaced value");
            Assert.IsTrue(example2.SequenceEqual(result2), "The collection shouldn't have the replaced value");
            Assert.IsTrue(example3.SequenceEqual(result3), "The collection shouldn't have the replaced value");
            Assert.IsTrue(result4, "The item in a collection shouldn't change it's position");
            Assert.IsFalse(result5, "All values should be swapped");
            Assert.IsTrue(result6, "The object in a collection should be swapped");
        }
    }
}
