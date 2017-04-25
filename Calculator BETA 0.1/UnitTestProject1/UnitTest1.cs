using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
             Calculator x = new Calculator();
            float d =  x.Plus(10, 20);
            Assert.AreEqual(30, d);
        }
    }
}