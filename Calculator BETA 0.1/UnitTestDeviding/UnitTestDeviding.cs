using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestDeviding
{
    [TestClass]
    public class UnitTestDeviding
    {
        [TestMethod]
        public void TestMethod4()
        {
            Calculator x = new Calculator();
            float d = x.Dividing(56, 8);
            Assert.AreEqual(d, 7); 

        }
    }
}
