using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestSimple

{
    [TestClass]
    public class TestSimpleCalc
    {
        [TestMethod]
        public void Plus()
        {
            Calculator Calc = new Calculator();
            float result = Calc.Plus(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Minus()
        {
            Calculator x = new Calculator();
            float d = x.Minus(25, 5);
            Assert.AreEqual(20, d);
        }




        [TestMethod]
        public void Divide()
        {
            Calculator x = new Calculator();
            float d = x.Dividing(56, 8);
            Assert.AreEqual(d, 7);

        }






        [TestMethod]
        public void Multiply()
        {
            Calculator x = new Calculator();
            float d = x.Multiply(5, 8);
            Assert.AreEqual(40, d);
        }
    }
}
    


