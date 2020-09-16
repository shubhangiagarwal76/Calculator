using Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WindowsForm
{
    class ExpressionEvaluation
    {
        public double Evaluate(string expression)
        {
            string[] tokens = expression.TrimStart(' ').TrimEnd(' ').Split(' ');

            // Stack for numbers: 'values'  
            Stack<double> values = new Stack<double>();

            // Stack for Operators: 'ops'  
            Stack<string> ops = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++)
            {

                // Current token is a number, push it to stack for numbers  
                if (tokens[i].Equals(""))
                    continue;

                // Current token is an opening brace, push it to 'ops'  
                if (tokens[i].Equals("("))
                {
                    ops.Push(tokens[i]);
                }

                // Closing brace encountered, solve entire brace  
                else if (tokens[i].Equals(")"))
                {
                    
                    while (!ops.Peek().Equals("("))
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                        
                    }
                    
                    ops.Pop();
                }

                // Current token is an operator.  
                else if (tokens[i].Equals("+") || tokens[i].Equals("-") || tokens[i].Equals("*") || tokens[i].Equals("/") || tokens[i].Equals("^") || tokens[i].Equals("%"))
                {
                    // While top of 'ops' has same or greater precedence to current  
                    // token, which is an operator. Apply operator on top of 'ops'  
                    // to top two elements in values stack  
                    while (ops.Count > 0 && hasPrecedence(tokens[i], ops.Peek()))
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }

                    // Push current token to 'ops'.  
                    ops.Push(tokens[i]);
                }
                else
                {
                    values.Push(double.Parse(tokens[i]));
                }
            }

            // Entire expression has been parsed at this point, apply remaining  
            // ops to remaining values  
            while (ops.Count > 0)
            {
                values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            // Top of 'values' contains result, return it  
                double result = values.Pop();
            if (values.Any())
                throw new FormatException("Invalid Exception");
            else
                return result;
        }

        // Returns true if 'op2' has higher or same precedence as 'op1',  
        // otherwise returns false.  
        public static bool hasPrecedence(string op1, string op2)
        {
            if (op2.Equals("(") || op2.Equals(")"))
            {
                return false;
            }
            if (op1.Equals("^") && (op2.Equals("*") || op2.Equals("/") || op2.Equals("+") || op2.Equals("-")))
            {
                return false;
            }
            if ((op1.Equals("*") || op1.Equals("/") || op1.Equals("%") && (op2.Equals("+") || op2.Equals("-"))))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // A utility method to apply an operator 'op' on operands 'a'   
        // and 'b'. Return the result.  
        public static double applyOp(string op, double b, double a)
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            switch (op)
            {
                case "+":
                    return arithmeticOperations.Add(a, b);
                case "-":
                    return arithmeticOperations.Subtract(a, b);
                case "*":
                    return arithmeticOperations.Multiply(a, b);
                case "/":
                    return arithmeticOperations.Divide(a,b);
                case "^":
                    return arithmeticOperations.Exponent(a, b);
                case "%":
                    return arithmeticOperations.Percentage(a, b);

            }
            return 0;
        }
    }
}
