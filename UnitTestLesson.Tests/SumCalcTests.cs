using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLesson.Tests
{
    [TestClass]
    public class SumCalcTests
    {
        [TestMethod]
        public void SumCalc_10and20_30()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            Tasks c = new Tasks();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class Boolean23Tests 
    { 
        [TestMethod]
        public void Boolean23_2442_true()
        {
            int a = 2442;       
            bool expected = true;

            Tasks c = new Tasks();
            bool actual = c.Boolean23(a);

            Assert.AreEqual(expected, actual);
        }

    }
}
