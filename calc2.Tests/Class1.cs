using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace calc2.Tests
{

    [TestClass]
    public class CalcTests
    {

        [TestMethod]
        public void AddOne()
        {            
            Assert.AreEqual(1, Calc2.Add(@"1,"));
        }

        [TestMethod]
        public void AddTwo()
        {
            Assert.AreEqual(3, Calc2.Add(@"1\n2"));
        }

        [TestMethod]
        public void AddEmpty()
        {
            Assert.AreEqual(0, Calc2.Add(@""));
        }

        [TestMethod]
        public void CustomSeparatorTest()
        {
            string str = @"//;\n1;2";
            Assert.AreEqual(3, Calc2.Add(str)); 

        }

        [TestMethod]
        public void CustomSeparatorTest2()
        {
            string str = @"//.\n1.2";
            Assert.AreEqual(3, Calc2.Add(str)); 
        }

    }
}
