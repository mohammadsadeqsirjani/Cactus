﻿using Cactus.Blade.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueObject.Test
{
    [TestClass]
    public class ValueObjectTests
    {
        [TestMethod]
        public void Equals_NullIsConsideredEqual()
        {
            var value1 = new TestValue();
            var value2 = new TestValue();

            AssertEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_OnlyOneValueIsNull_DoesNotThrow_NotEqual()
        {
            var value1 = new TestValue();
            var value2 = new TestValue { Property1 = "value" };

            AssertNotEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_ComparesAllPropertiesAndFields_Equal()
        {
            var value1 = new TestValue { Property1 = "test", Property2 = 10, Field = 3 };
            var value2 = new TestValue { Property1 = "test", Property2 = 10, Field = 3 };

            AssertEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_ComparesAllPropertiesAndFields_PropertyDifferent_NotEqual()
        {
            var value1 = new TestValue { Property1 = "test", Property2 = 10 };
            var value2 = new TestValue { Property1 = "Test", Property2 = 10 };

            AssertNotEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_ComparesAllPropertiesAndFields_FieldDifferent_NotEqual()
        {
            var value1 = new TestValue { Property1 = "test", Property2 = 10, Field = 8 };
            var value2 = new TestValue { Property1 = "test", Property2 = 10, Field = 9 };

            AssertNotEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_IgnoresPrivatePropertiesAndFields()
        {
            var value1 = new TestValue(5);
            var value2 = new TestValue(8);

            AssertEqual(value1, value2);
        }

        [TestMethod]
        public void Equals_ComparingWithNull_ReturnsFalse()
        {
            var value = new TestValue { Property1 = "string" };

            Assert.IsFalse(value.Equals(null as object));
        }

        [TestMethod]
        public void Equals_ComparingWithWrongType_ReturnsFalse()
        {
            var value = new TestValue { Property1 = "string" };

            Assert.IsFalse(false);
        }

        [TestMethod]
        public void OperatorEquals_LeftSideNull_ReturnsFalse()
        {
            var value = new TestValue();

            Assert.IsFalse(null == value);
        }

        [TestMethod]
        public void OperatorEquals_RightSideNull_ReturnsFalse()
        {
            var value = new TestValue();

            Assert.IsFalse(value == null);
        }

        [TestMethod]
        public void OperatorEquals_BothValuesNull_ReturnsTrue()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void OperatorNotEquals_LeftSideNull_ReturnsTrue()
        {
            var value = new TestValue();

            Assert.IsTrue(null != value);
        }

        [TestMethod]
        public void OperatorNotEquals_RightSideNull_ReturnsTrue()
        {
            var value = new TestValue();

            Assert.IsTrue(value != null);
        }

        [TestMethod]
        public void OperatorNotEquals_BothValuesNull_ReturnsFalse()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void ImplementsIEquatable()
        {
            var value = new TestValue();

            Assert.IsInstanceOfType(value, typeof(IEquatable<Cactus.Blade.ValueObject.ValueObject>));
        }

        [TestMethod]
        public void GetHashCode_AlwaysEqualForEqualObjects()
        {
            var value1 = new TestValue { Property1 = "string", Property2 = 4 };
            var value2 = new TestValue { Property1 = "string", Property2 = 4 };

            Assert.AreEqual(value1.GetHashCode(), value2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCode_NotEqualForDistinctObjects_1()
        {
            var value1 = new TestValue { Property1 = "string", Property2 = 4 };
            var value2 = new TestValue { Property1 = "string", Property2 = 5 };

            Assert.AreNotEqual(value1.GetHashCode(), value2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCode_NotEqualForDistinctObjects_2()
        {
            var value1 = new TestValue { Property1 = "string", Property2 = 4 };
            var value2 = new TestValue { Property1 = "String", Property2 = 4 };

            Assert.AreNotEqual(value1.GetHashCode(), value2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCode_HandlesNull()
        {
            var value1 = new TestValue { Property2 = 2 };
            var value2 = new TestValue { Property2 = 5 };

            Assert.AreNotEqual(value1.GetHashCode(), value2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCode_ConsidersPublicFields()
        {
            var value1 = new TestValue { Property2 = 2 };
            var value2 = new TestValue { Property2 = 2, Field = 4 };

            Assert.AreNotEqual(value1.GetHashCode(), value2.GetHashCode());
        }

        private static void AssertEqual(TestValue value1, TestValue value2)
        {
            Assert.AreEqual(value1, value2);
            Assert.IsTrue(value1 == value2);
            Assert.IsFalse(value1 != value2);
            Assert.IsTrue(value1.Equals(value2));
        }

        private static void AssertNotEqual(TestValue value1, TestValue value2)
        {
            Assert.AreNotEqual(value1, value2);
            Assert.IsTrue(value1 != value2);
            Assert.IsFalse(value1 == value2);
            Assert.IsFalse(value1.Equals(value2));
        }

        private class Recursive : Cactus.Blade.ValueObject.ValueObject
        {
            public Recursive Recurse { get; set; }
            public string Terminal;
        }

        [TestMethod]
        public void Nesting()
        {
            var value = new Recursive();
            var value2 = new Recursive();
            var nestedValue = new Recursive() { Terminal = "test" };
            var nestedValue2 = new Recursive() { Terminal = "test" };

            value.Recurse = nestedValue;
            value2.Recurse = nestedValue2;

            Assert.IsTrue(value.Equals(value2));
            Assert.AreEqual(value.GetHashCode(), value2.GetHashCode());
        }

        private class Ignore : Cactus.Blade.ValueObject.ValueObject
        {
            [IgnoreMember] public int Ignored { get; set; }
            [IgnoreMember] public int IgnoredField;
            public int Considered { get; set; }
        }

        [TestMethod]
        public void IgnoreMember_Property_DoesNotConsider()
        {
            var value1 = new Ignore { Ignored = 2, Considered = 4 };
            var value2 = new Ignore { Ignored = 3, Considered = 4 };

            Assert.IsTrue(value1.Equals(value2));
        }

        [TestMethod]
        public void IgnoreMember_Field_DoesNotConsider()
        {
            var value1 = new Ignore { IgnoredField = 3, Considered = 4 };
            var value2 = new Ignore { IgnoredField = 2, Considered = 4 };

            Assert.IsTrue(value1.Equals(value2));
        }

        private class MyValue : Cactus.Blade.ValueObject.ValueObject
        {
            public int Num { get; set; }
        }

        private class MyValue2 : MyValue
        {
        }

        [TestMethod]
        public void ObjectsOfDifferentTypeAreNotEqual_EvenIfSubclass()
        {
            var value1 = new MyValue();
            var value2 = new MyValue2();

            Assert.IsFalse(value1.Equals(value2));
        }
    }
}
