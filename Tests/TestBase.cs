using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    public abstract class TestBase
    {
        protected IFizzBuzz FizzBuzz { get; set; }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Null_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Empty_String_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new string[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Single_Element_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new string[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Three_Element_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new string[3]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Non_Integer_Right_Size_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new[] { "a", "b" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Partial_Non_Integer_Right_Size_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new[] { "a", "3" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Partial_Non_Integer_Inverted_Right_Size_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new[] { "3", "a" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Right_Size_Wrong_Order_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new[] { "20", "1" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Value_Array_Input_Throws_ArgumentException_TestMethod()
        {
            FizzBuzz.ExecuteFizzBuzz(new[] { "-1", "20" });
        }
    }
}