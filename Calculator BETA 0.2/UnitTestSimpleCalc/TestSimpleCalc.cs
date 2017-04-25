using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestSimple

{
    [TestClass]
    public class TestSimpleCalc
    {
        [TestMethod]
        public void addition()
        {
            Calculator Calc = new Calculator();
            float result = Calc.Plus(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void subtraction()
        {
            Calculator Calc = new Calculator();
            float result = Calc.Minus(25, 5);
            Assert.AreEqual(20, result);
        }

        


        [TestMethod]
        public void division()
        {
            Calculator Calc = new Calculator();
            float result = Calc.Dividing(56, 8);
            Assert.AreEqual(result, 7);

        }






        [TestMethod]
        public void multiplication()
        {
            Calculator Calc = new Calculator();
            float result = Calc.Multiply(5, 8);
            Assert.AreEqual(40, result);
        }
    }
}
    


