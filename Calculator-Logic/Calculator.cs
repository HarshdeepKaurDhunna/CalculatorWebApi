using System;

namespace Calculator_Logic
{
    public class Calculator
    {
       
        /*
         * @method Add to numbers
         * @arguments 2 Double value left and right
         * @return Single double Value 
         */
        public static double Addition(double left, double right)
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

        /*
         * @method subtract to numbers
         * @arguments 2 Double value left and right
         * @return Single double Value 
         */
        public static double Subtraction(double left, double right)
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

        /*
         * @method Multiply to numbers
         * @arguments 2 Double value left and right
         * @return Single double Value 
         */
        public static double Multiplication(double left, double right)
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

        /*
         * @method Divide to numbers
         * @arguments 2 Double value left and right
         * @return Single double Value 
         */
        public static double Divide(double left, double right)
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
