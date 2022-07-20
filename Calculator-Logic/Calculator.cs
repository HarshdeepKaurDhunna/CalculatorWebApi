using System;

namespace Calculator_Logic
{
    public class Calculator
    {
       
        public double Addition(double left, double right)
        {
        
            try
            {
                return left + right;
            }
            catch (FormatException)
            {
                throw new ArgumentException();
            }
        }

        public double Subtraction(double left, double right)
        {

            try
            {
                return left - right;
            }
            catch (FormatException)
            {
                throw new ArgumentException();
            }
        }

        public double Multiplication(double left, double right)
        {

            try
            {
                return left * right;
            }
            catch (FormatException)
            {
                throw new ArgumentException();
            }
        }
        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
    }
}
