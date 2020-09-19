using Grapecity.Internship.Assignment.Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapecity.Internship.Assignment.Calculator.ConsoleApp
{
    public class ResultCalculation
    {
        ScientificOperations operations = new ScientificOperations();
        double Number1, Number2;
        public double Result
        {
            get;
            set;
        }

        public void Reset()
        {
            Result = 0;
        }
        
        public void Input2Numbers(int option)
        {
            Reset();
            try
            {
                if (option > 6)
                    throw new FormatException();

                Console.WriteLine(Properties.StringResource.Number1);
                Number1 = Double.Parse(Console.ReadLine());
                Console.WriteLine(Properties.StringResource.Number2);
                Number2 = Double.Parse(Console.ReadLine());
                
                Result = CalculateResult(option, Number1, Number2);
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
                Number1 = Double.Parse(Console.ReadLine());
                
                Result = CalculateResult(option, Number1);
            }
            catch
            {
                Console.WriteLine(Properties.StringResource.InvalidOption);
            }

        }

        public double CalculateResult(int option, double num1, double num2)
        {


            Result = (option==1)? operations.Addition(num1, num2) :
                     (option==2)? operations.Subtract(num1, num2):
                     (option==3)? operations.Multiply(num1, num2):
                     (option==4)? operations.Divide(num1, num2):
                     (option==5)? operations.Percentage(num1,num2):
                     (option==6)? operations.Exponent(num1, num2): 0.0;

            //Can also use ternary to avoid switch case and if...if else
            return Result;
        }
        public double CalculateResult(int option, double num1)
        {
            Result = (option == 1) ? operations.SquareRoot(num1) :
                     (option == 2) ? operations.LogBaseE(num1) :
                     (option == 3) ? operations.LogBase10(num1) :
                     (option == 4) ? operations.Sine(num1) :
                     (option == 5) ? operations.Cosine(num1) :
                     (option == 6) ? operations.Tangent(num1) : 0.0;
           
            return Result;
        }
    }
}
