using Grapecity.Internship.Assignment.Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapecity.Internship.Assignment.Calculator.WindowsForm
{
    class ExpressionEvaluation
    {
        public double Evaluate(string expression)
        {
            string[] Tokens = expression.TrimStart(' ').TrimEnd(' ').Split(' ');
  
            Stack<double> Values = new Stack<double>();
 
            Stack<string> Operators = new Stack<string>();

            for (int index = 0; index < Tokens.Length; index++)
            {
                if (Tokens[index].Equals(""))
                    continue;

                if (Tokens[index].Equals("("))
                    Operators.Push(Tokens[index]);
               
                else if (Tokens[index].Equals(")"))
                {
                    
                    while (!Operators.Peek().Equals("("))
                        Values.Push(ApplyOperations(Operators.Pop(), Values.Pop(), Values.Pop()));
                    Operators.Pop();
                }

                else if (Tokens[index].Equals("+") || Tokens[index].Equals("-") || Tokens[index].Equals("*") || Tokens[index].Equals("/") || Tokens[index].Equals("^") || Tokens[index].Equals("%") || Tokens[index].Equals("Sin") || Tokens[index].Equals("Cos") || Tokens[index].Equals("Tan") || Tokens[index].Equals("Log") || Tokens[index].Equals("Log10") || Tokens[index].Equals("1/x"))
                {
                    while (Operators.Count > 0 && HasPrecedence(Tokens[index], Operators.Peek()))
                    {
                        if (IsUnary(Operators.Peek()))
                            Values.Push(applyOp(Operators.Pop(), Values.Pop()));
                        else
                            Values.Push(ApplyOperations(Operators.Pop(), Values.Pop(), Values.Pop()));
                    }

                    Operators.Push(Tokens[index]);
                }
                else
                {
                    Values.Push(double.Parse(Tokens[index]));
                }
            }
            while (Operators.Count > 0)
            {
                if (IsUnary(Operators.Peek()))
                    Values.Push(applyOp(Operators.Pop(), Values.Pop()));
                else
                    Values.Push(ApplyOperations(Operators.Pop(), Values.Pop(), Values.Pop()));
            }
            double result = Values.Pop();
            if (Values.Any())
                throw new FormatException("Invalid Exception");
            else
                return result;
        }

        public static bool HasPrecedence(string operator1, string operator2)
        {
            if (operator2.Equals("(") || operator2.Equals(")"))
                return false;

            if ((operator1.Equals("^") || operator1.Equals("Sin") || operator1.Equals("Cos") || operator1.Equals("Tan") || operator1.Equals("Log") || operator1.Equals("Log10") || operator1.Equals("1/x") )&& (operator2.Equals("*") || operator2.Equals("/") || operator2.Equals("+") || operator2.Equals("-")))
                return false;

            if ((operator1.Equals("*") || operator1.Equals("/") || operator1.Equals("%")) && (operator2.Equals("+") || operator2.Equals("-")))
                return false;

            else
                return true;
            
        }

        public static double ApplyOperations(string operators, double secondNumber, double firstNumber)
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            switch (operators)
            {
                case "+":
                    return arithmeticOperations.Addition(firstNumber, secondNumber);
                case "-":
                    return arithmeticOperations.Subtract(firstNumber, secondNumber);
                case "*":
                    return arithmeticOperations.Multiply(firstNumber, secondNumber);
                case "/":
                    return arithmeticOperations.Divide(firstNumber,secondNumber);
                case "^":
                    return arithmeticOperations.Exponent(firstNumber, secondNumber);
                case "%":
                    return arithmeticOperations.Percentage(firstNumber, secondNumber);

            }
            return 0;
        }
        public static double applyOp(string operators, double firstNumber)
        {
            switch (operators)
            {
                case "Sin":
                    return Math.Sin(firstNumber);
                case "Cos":
                    return Math.Cos(firstNumber);
                case "Tan":
                    return Math.Tan(firstNumber);
                case "Log":

                    return Math.Log10(firstNumber);
                case "Ln":
                    return Math.Log(firstNumber);
                case "1/x":
                    if (firstNumber == 0)
                        throw new ArithmeticException();
                    return 1 / firstNumber;

            }
            return 0;
        }
        public bool IsUnary(string operators)
        {
            if (operators.Equals("Sin") || operators.Equals("Cos") || operators.Equals("Tan") || operators.Equals("Log") || operators.Equals("Ln") || operators.Equals("1/x"))
                return true;
            return false;
        }
    }
}
