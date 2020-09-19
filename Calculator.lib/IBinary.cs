using Grapecity.Internship.Assignment.Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.lib
{
    public interface IBinary
    {
        double CalculateResult(int option, double num1, double num2);
    }
    public class Addition : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Addition(num1, num2);
        }
    }
    public class Subtraction : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Subtract(num1, num2);
        }
    }
    public class Multiplication : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Multiply(num1, num2);
        }
    }
    public class Division : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Divide(num1, num2);
        }
    }
    public class Percentage : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Percentage(num1, num2);
        }
    }
    public class Exponent : IBinary
    {
        public double CalculateResult(int option, double num1, double num2)
        {
            ScientificOperations operations = new ScientificOperations();
            return operations.Exponent(num1, num2);
        }
    }
}
