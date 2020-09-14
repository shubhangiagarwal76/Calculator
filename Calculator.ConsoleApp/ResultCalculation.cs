using Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    public class ResultCalculation
    {
        ArithmeticOperations operations = new ArithmeticOperations();
        double number1, number2;
        public double result
        {
            get;
            set;
        }

        public void Reset()
        {
            result = 0;
        }
        
        public void Input2Numbers(int option)
        {
            Reset();
            try
            {
                if (option > 6)
                    throw new FormatException();

                Console.WriteLine(Properties.StringResource.Number1);
                number1 = Double.Parse(Console.ReadLine());
                Console.WriteLine(Properties.StringResource.Number2);
                number2 = Double.Parse(Console.ReadLine());
                
                result = CalculateResult(option, number1, number2);
            }
            catch
            {
                Console.WriteLine(Properties.StringResource.InvalidOption);
                
            }

        }
        public void Input1Number(int option)
        {
            Reset();
            try
            {
                if (option > 6)
                    throw new FormatException();

                Console.WriteLine(Properties.StringResource.Number);
                number1 = Double.Parse(Console.ReadLine());
                
                result = CalculateResult(option, number1);
            }
            catch
            {
                Console.WriteLine(Properties.StringResource.InvalidOption);
            }

        }

        public double CalculateResult(int option, double num1, double num2)
        {


            result = (option==1)? operations.Add(num1, num2) :
                     (option==2)? operations.Subtract(num1, num2):
                     (option==3)? operations.Multiply(num1, num2):
                     (option==4)? operations.Divide(num1, num2):
                     (option==5)? operations.Percentage(num1,num2):
                     (option==6)? operations.Exponent(num1, num2): 0.0;

            //Can also use ternary to avoid switch case and if...if else
            return result;
        }
        public double CalculateResult(int option, double num1)
        {
            result = (option == 1) ? operations.SquareRoot(num1) :
                     (option == 2) ? operations.LogBaseE(num1) :
                     (option == 3) ? operations.LogBase10(num1) :
                     (option == 4) ? operations.Sine(num1) :
                     (option == 5) ? operations.Cosine(num1) :
                     (option == 6) ? operations.Tangent(num1) : 0.0;
           
            return result;
        }
    }
}
