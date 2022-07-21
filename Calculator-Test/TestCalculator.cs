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

        [TestMethod]
        [DataRow(-50, -40, -10)]
        [DataRow(-51.980000000000004, -40.99, -10.99)]
        public void CalculatorCanAddNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }

        [TestMethod]
        [DataRow(30, 40, -10)]
        [DataRow(-30, -40, 10)]
        public void CalculatorCanAddPositiveAndNegativeValues(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }

        [TestMethod]
        [DataRow(10, 0, 10)]
        [DataRow(30.99, 30.99, 0)]
        public void CalculatorCanAddPositiveAndZeroValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }

        [TestMethod]
        [DataRow(-10, 0, -10)]
        [DataRow(-30.99, -30.99, 0)]
        public void CalculatorCanAddNegativeAndZeroValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }

    }
}
