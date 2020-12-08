using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.System.Object
{
    [TestClass]
    public class SystemObjectToNullableInt32OrDefault
    {
        [TestMethod]
        public void ToNullableInt32OrDefault()
        {
            const string thisValid = "32";
            const string thisInvalid = "FizzBuzz";
            string @thisNull = null;

            var result1 = @thisValid.ToNullableInt32OrDefault();
            var result2 = @thisInvalid.ToNullableInt32OrDefault();
            var result3 = @thisInvalid.ToNullableInt32OrDefault(-1);
            var result4 = @thisInvalid.ToNullableInt32OrDefault(() => -2);
            var result5 = @thisNull.ToNullableInt32OrDefault();

            Assert.AreEqual(32, result1.Value);
            Assert.AreEqual(0, result2.Value);
            Assert.AreEqual(-1, result3.Value);
            Assert.AreEqual(-2, result4.Value);
            Assert.IsFalse(result5.HasValue);
        }
    }
}
