using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;
namespace UnitTestMinus
{
    [TestClass]
    public class TestMinus
    {
        [TestMethod]
        public void Minus()
        {
            Calculator x = new Calculator();
            float d = x.Minus(25,5);
            Assert.AreEqual(20,d);
        }
    }
}
