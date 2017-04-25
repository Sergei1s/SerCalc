using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestMultiply
{
    [TestClass]
    public class UnitTestMultiplication
    {
        [TestMethod]
        public void TestMethod3()
        {
            Calculator x = new Calculator();
            float d = x.Multiply(5, 8);
            Assert.AreEqual(40, d);
        }
    }
}
