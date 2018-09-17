using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math = MyMathDLL.Math;

namespace MyMathDLLTest
{
    [TestClass]
    public class MyMathTest
    {
        Math m = new Math();
        [TestMethod]
        public void AddTest()
        {
            
            Assert.IsTrue(m.Add(2,3).Equals(5));
        }
        [TestMethod]
        public void AddTestNegativeNumber()
        {

            Assert.AreEqual(m.Add(-3, -4), -7);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.IsTrue(m.Multiply(2,2, 2).Equals(8));
        }
    }
}
