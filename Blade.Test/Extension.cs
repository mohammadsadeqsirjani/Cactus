using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;

namespace Blade.Test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class Extension
    {
        [TestMethod]
        public void TestJsonToExpandoObject()
        {
            const string json =
                "{'name':'Widget','expiryDate':'2010-12-20T18:01Z', 'price':9.99,'sizes':['Small','Medium','Large']}";

            dynamic product = json.JsonToExpanderObject();

            Assert.IsInstanceOfType(product, typeof(ExpandoObject));

            Assert.IsNotNull(product.name);
            Assert.IsNotNull(product.expiryDate);
            Assert.IsNotNull(product.price);
            Assert.IsNotNull(product.sizes);

            var sizes = (List<object>)product.sizes;
            foreach (string item in sizes)
            {
                Assert.IsNotNull(item);
            }
        }

        [TestMethod]
        public void TestLength()
        {
            var sample = "There is currently no easy way to update all packages within a solution";
            Assert.IsTrue(sample.IsMinLength(2));

            sample = "The running";
            Assert.IsFalse(sample.IsMinLength(50));

            sample = null;
            Assert.IsFalse(sample.IsMinLength(1));

            sample = "One";
            Assert.IsTrue(sample.IsMaxLength(3));

            sample = "three";
            Assert.IsFalse(sample.IsMaxLength(3));
        }

        [TestMethod]
        public void TestDoesNotStartWith()
        {
            Assert.IsTrue("test".DoesNotStartWith("a"));
            Assert.IsFalse("test".DoesNotStartWith("t"));
            Assert.IsTrue("".DoesNotStartWith("t"));

            string value = null;

            Assert.IsTrue(value.DoesNotStartWith("t"));
        }

        [TestMethod]
        public void ToTextElements()
        {
            const string testing = "asdfasdf aasdflk asdfasdf";

            IEnumerable<string> a = testing.ToTextElements();

            foreach (var k in a) Console.WriteLine(k);
        }

        [TestMethod]
        public void TestIPv4Address()
        {
            Assert.IsFalse("64.233.161.1470".IsValidIPv4());
            Assert.IsTrue("64.233.161.147".IsValidIPv4());
        }

        [TestMethod]
        public void TestQueryStringToDictionary()
        {
            const string url = "?name=ferret&field1=value1&field2=value2&field3=value3";

            var queryValues = url.QueryStringToDictionary();

            Assert.IsNotNull(queryValues);

            foreach (var obj in queryValues) Console.WriteLine("key={0},value={1}", obj.Key, obj.Value);
        }

        [TestMethod]
        public void TestIsAlphaOrNumeric()
        {
            Assert.IsTrue("Burning bridges as we go".IsAlpha());
            Assert.IsFalse("Burning bridges as we go!".IsAlpha());
            Assert.IsTrue("10 minutes left to code".IsAlphaNumeric());
            Assert.IsTrue("123456".IsAlphaNumeric());
        }

        [TestMethod]
        public void TestRemovePrefixSuffix()
        {
            Assert.AreEqual("berbahaya".RemovePrefix("ber", false), "bahaya");
            Assert.AreEqual("masakan".RemoveSuffix("an"), "masak");
        }

        [TestMethod]
        public void TestJsonStringToObject()
        {
            const string productString =
                "{'name':'Widget','expiryDate':'2010-12-20T18:01Z', 'price':9.99,'sizes':['Small','Medium','Large']}";

            var product = productString.JsonToObject<Product>();
            Assert.IsNotNull(product);
            Console.WriteLine(product);

            const string productListString =
                "[{'name':'Widget','expiryDate':'2010-12-20T18:01Z','price':9.99,'sizes':['Small','Medium','Large']}," +
                "{'name':'Image','expiryDate':'2015-12-20T18:01Z','price':20.50,'sizes':['Small','Medium','Large','Extra Large']}]";

            var products = productListString.JsonToObject<List<Product>>();
            Assert.IsNotNull(products);

            foreach (var value in products) Console.WriteLine(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestToEnum()
        {
            var gauge = "VeryHigh".ToEnum(Temperature.High);
            Assert.IsTrue(gauge.Equals(Temperature.High));

            gauge = "low".ToEnum(Temperature.Unknown);
            Assert.IsTrue(gauge.Equals(Temperature.Low));

            gauge = "veryHigh".ToEnum<Temperature>();
            Assert.IsTrue(gauge.Equals(Temperature.Unknown));

            gauge = "Medium".ToEnum<Temperature>();
            Assert.IsTrue(gauge.Equals(Temperature.Medium));

            Assert.IsInstanceOfType("high".ToEnum<int>(), typeof(Temperature));
        }

        [TestMethod]
        public void TestCountOccurrences()
        {
            const string sentence = "hey man! i went to the apple store, hey man! are you listening to me";
            Assert.IsTrue(sentence.CountOccurrences("HEY MAN!") == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(CryptographicException))]
        public void TestEncryptDecrypt()
        {
            const string key = "1234567890!@#$%^&*()_+";
            const string stringToEncrypt = "In my opinion best movie released 2014 is prometheus";

            var encryptedString = stringToEncrypt.Encrypt(key);
            var decryptedString = encryptedString.Decrypt(key);

            Assert.AreEqual(stringToEncrypt, decryptedString);
            encryptedString.Decrypt("wrongkey");
        }
    }
}
