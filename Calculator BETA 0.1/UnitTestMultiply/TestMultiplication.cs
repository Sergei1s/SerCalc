using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestMultiply
{
    [TestClass]
    public class TestMultiplication
    {
        [TestMethod]
        public void Multiply()
        {
            Calculator x = new Calculator();
            float d = x.Multiply(5, 8);
            Assert.AreEqual(40, d);
        }
    }
}
