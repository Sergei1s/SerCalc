using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestDevide
{
    [TestClass]
    public class UnitTestDevide
    {
        [TestMethod]
        public void Divide()
        {
            Calculator x = new Calculator();
            float d = x.Dividing(56, 8);
            Assert.AreEqual(d, 7); 

        }
    }
}
