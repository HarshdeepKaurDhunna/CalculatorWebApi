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

                        /** Addition Test Methods **/

        [TestMethod]
        [DataRowAttribute(3, 1, 2)]
        [DataRowAttribute(4.46, 1.56, 2.90)]
        public void CalculatorCanAddTwoPositiveNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Addition(left, right));

        }

        [TestMethod]
        [DataRow(-50, -40, -10)]
        [DataRow(-51.98, -40.99, -10.99)]
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



                              /** Subtraction Test Methods **/

        [TestMethod]
        [DataRowAttribute(1, 2, 1)]
        [DataRowAttribute(1.57, 2.67, 1.10)]
        public void CalculatorCanSubtractTwoPositiveNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Subtraction(left, right));

        }

        [TestMethod]
        [DataRow(-30, -40, -10)]
        [DataRow(-30, -40.99, -10.99)]
        public void CalculatorCanSubtractNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Subtraction(left, right));

        }

        [TestMethod]
        [DataRow(50, 40, -10)]
        [DataRow(51.98, 40.99, -10.99)]
        public void CalculatorCanSubtractPositiveAndNegativeValues(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Subtraction(left, right));

        }

        [TestMethod]
        [DataRow(-10, 0, 10)]
        [DataRow(30.99, 30.99, 0)]
        public void CalculatorCanSubtractPositiveAndZeroValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Subtraction(left, right));

        }

        [TestMethod]
        [DataRow(10, 0, -10)]
        [DataRow(-30.99, -30.99, 0)]
        public void CalculatorCanSubtractNegativeAndZeroValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Subtraction(left, right));

        }

                            /** Division Test Methods **/

        [TestMethod]
        [DataRow(2, 2, 1)]
        [DataRow(1.4, 7, 5)]
        [DataRow(1.33, 7.99, 5.99)]
        public void CalculatorCanDivideTwoPositiveNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Divide(left, right));

        }


        [TestMethod]
        [DataRow(0.25, -10, -40)]
        [DataRow(3.64, -40, -10.99)]
        public void CalculatorCanDivideNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Divide(left, right));

        }

        [TestMethod]
        [DataRow(-4, 40, -10)]
        [DataRow(-3.73, 40.99, -10.99)]
        public void CalculatorCanDividePositiveAndNegativeValues(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Divide(left, right));

        }

        [TestMethod]
        [DataRow(0, 0, 10)]
        [DataRow(0, 0, 11.99)]
        public void CalculatorCanDivideZeroAndPositiveValues(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Divide(left, right));

        }
        [TestMethod]
        [DataRow(0, 0, -10)]
        [DataRow(0, 0, -11.99)]
        public void CalculatorCanDivideZeroAndNegativeValues(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Calc.Divide(left, right));

        }
        public void CalculatorThrowExceptionWhenDividingByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { Calc.Divide(3, 0); });

        }


    }
}
