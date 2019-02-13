using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FizzBuzzTest : TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            FizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [TestMethod]
        public void Range_1_20_TestMethod()
        {
            Assert.AreEqual(FizzBuzz.ExecuteFizzBuzz(new[] { "1", "20" }), "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz ");
        }
    }
}