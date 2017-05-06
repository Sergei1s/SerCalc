using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;

namespace UnitTestSimple

{
    [TestClass]
    public class TestSimpleCalc
    {
        [TestMethod]
        public void  ShouldPlusTwoVariablesTest()
        {
            var calc = new Calculator();
            var result = calc.Plus(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void ShouldSubtractTwoVariablesTest()
        {
            var calc = new Calculator();
            var result = calc.Minus(25, 5);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SouldDivideTwoVariablesTest()
        {
            var calc = new Calculator();
            var result = calc.Divide(56, 8);
            Assert.AreEqual(result, 7);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ShouldRaiseExeption_WhenDeliverEqualsZero_Test()
        {
            var calc = new Calculator();
            var result = calc.Divide(56, 0);
        }

        [TestMethod]
        public void ShouldMultiplyTwoVariablesTest()
        {
            var calc = new Calculator();
            var result = calc.Multiply(5, 8);
            Assert.AreEqual(40, result);
        }
    }
}
  