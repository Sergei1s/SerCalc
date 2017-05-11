using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class SimpleCalculatorTests
    {
        [TestMethod]
        public void  ShouldPlusTwoVariablesTest()
        {
            var calculator = new Calculator1.Calculator();
            var result = calculator.Plus(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void ShouldSubtractTwoVariablesTest()
        {
            var calculator = new Calculator1.Calculator();
            var result = calculator.Minus(25, 5);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void ShouldDivideTwoVariablesTest()
        {
            var calculator = new Calculator1.Calculator();
            var result = calculator.Divide(56, 8);
            Assert.AreEqual(result, 7);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ShouldRaiseExeption_WhenDeliverEqualsZero_Test()
        {
            var calc = new Calculator1.Calculator();
            var result = calc.Divide(56, 0);
        }

        [TestMethod]
        public void ShouldMultiplyTwoVariablesTest()
        {
            var calc = new Calculator1.Calculator();
            var result = calc.Multiply(5, 8);
            Assert.AreEqual(40, result);
        }
    }
}
  