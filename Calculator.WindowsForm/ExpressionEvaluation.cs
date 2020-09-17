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

            for (int i = 0; i < Tokens.Length; i++)
            {
                if (Tokens[i].Equals(""))
                    continue;

                if (Tokens[i].Equals("("))
                    Operators.Push(Tokens[i]);
               
                else if (Tokens[i].Equals(")"))
                {
                    
                    while (!Operators.Peek().Equals("("))
                        Values.Push(ApplyOperations(Operators.Pop(), Values.Pop(), Values.Pop()));
                    Operators.Pop();
                }

                else if (Tokens[i].Equals("+") || Tokens[i].Equals("-") || Tokens[i].Equals("*") || Tokens[i].Equals("/") || Tokens[i].Equals("^") || Tokens[i].Equals("%") || Tokens[i].Equals("Sin") || Tokens[i].Equals("Cos") || Tokens[i].Equals("Tan") || Tokens[i].Equals("Log") || Tokens[i].Equals("Log10") || Tokens[i].Equals("1/x"))
                {
                    while (Operators.Count > 0 && HasPrecedence(Tokens[i], Operators.Peek()))
                    {
                        if (IsUnary(Operators.Peek()))
                            Values.Push(applyOp(Operators.Pop(), Values.Pop()));
                        else
                            Values.Push(ApplyOperations(Operators.Pop(), Values.Pop(), Values.Pop()));
                    }

                    Operators.Push(Tokens[i]);
                }
                else
                {
                    Values.Push(double.Parse(Tokens[i]));
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

        public static double ApplyOperations(string operators, double number2, double number1)
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            switch (operators)
            {
                case "+":
                    return arithmeticOperations.Addition(number1, number2);
                case "-":
                    return arithmeticOperations.Subtract(number1, number2);
                case "*":
                    return arithmeticOperations.Multiply(number1, number2);
                case "/":
                    return arithmeticOperations.Divide(number1,number2);
                case "^":
                    return arithmeticOperations.Exponent(number1, number2);
                case "%":
                    return arithmeticOperations.Percentage(number1, number2);

            }
            return 0;
        }
        public static double applyOp(string operators, double number1)
        {
            switch (operators)
            {
                case "Sin":
                    return Math.Sin(number1);
                case "Cos":
                    return Math.Cos(number1);
                case "Tan":
                    return Math.Tan(number1);
                case "Log":

                    return Math.Log10(number1);
                case "Ln":
                    return Math.Log(number1);
                case "1/x":
                    if (number1 == 0)
                        throw new ArithmeticException();
                    return 1 / number1;

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
