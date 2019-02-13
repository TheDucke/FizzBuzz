using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FizzBuzz3Test : TestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            FizzBuzz = new FizzBuzz3.FizzBuzz3();
        }

        [TestMethod]
        public void Range_1_20_TestMethod()
        {
            Assert.AreEqual(FizzBuzz.ExecuteFizzBuzz(new[] { "1", "20" }), "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz ");
        }
    }
}