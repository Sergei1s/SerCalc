using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;
namespace UnitTestMinus
{
    [TestClass]
    public class UnitTestMinus
    {
        [TestMethod]
        public void TestMethod2()
        {
            Calculator x = new Calculator();
            float d = x.Minus(25,5);
            Assert.AreEqual(20,d);
        }
    }
}
