using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Logic;

namespace Calculator_Test
{
    [TestClass]
    public class TestCalculator
    {
        Calculator? Calc = null;

        [TestInitialize]
        public void Instantiate()
        {
            Calc = new Calculator();
        }
        [TestCleanup]
        public void TearDown()
        {
            Calc = null;
        }
        [TestMethod]
        public void CalculatorCalssIsInstantiable()
        {
            Assert.IsNotNull(Calc);
        }

        [TestMethod]
        [DataRowAttribute(3, 1, 2)]
        [DataRowAttribute(double.MaxValue + 3, 1, double.MaxValue)]
        public void CalculatorCanAddTwoPositiveNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }
        public void CalculatorThrowExceptionWhenDividingByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { Calc.Divide(3, 0); });

        }
    }
}
