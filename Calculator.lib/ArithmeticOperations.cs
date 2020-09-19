using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapecity.Internship.Assignment.Calculator.lib
{
    public class ArithmeticOperations
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Exponent(double num1, double power)
        {
            return Math.Pow(num1, power);
        }

        public double Percentage(double num1, double num2)
        {
            return (num1 / num2) * 100;
        }

    }

}
