using Calculator.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calculator.ConsoleApp
{
    class CalculatorDisplay
    {
        double number1, number2;

        static void Main(string[] args)
        {

            ArithmeticOperations operations = new ArithmeticOperations();
            CalculatorDisplay obj = new CalculatorDisplay();
            int option;
            double result = 0;

            Console.WriteLine("***********"+Properties.StringResource.WelcomeMessage+ "***********");
            Console.WriteLine("\t"+Properties.StringResource.Options);
            Console.WriteLine("1." + Properties.StringResource.Add + "\n" + 
                "2." + Properties.StringResource.Subtract + "\n" +
                "3." + Properties.StringResource.Multiply + "\n" + 
                "4." + Properties.StringResource.Divide + "\n" +
                "5." + Properties.StringResource.Percent + "\n" + 
                "6." + Properties.StringResource.Exponent + "\n" + 
                "7." + Properties.StringResource.Sqrt + "\n" + 
                "8." + Properties.StringResource.Log + "\n" + 
                "9." + Properties.StringResource.Log10 + "\n" +
                "10." + Properties.StringResource.Sin + "\n" + 
                "11." + Properties.StringResource.Cos + "\n"+ 
                "12." + Properties.StringResource.Tan);
            Console.WriteLine("\t"+Properties.StringResource.Choice);
            option = Int32.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                    Input2Numbers(obj);
                    result = operations.Add(obj.number1, obj.number2);
                    break;
                case 2:
                    Input2Numbers(obj);
                    result = operations.Subtract(obj.number1, obj.number2);
                    break;
                case 3:
                    Input2Numbers(obj);
                    result = operations.Multiply(obj.number1, obj.number2);
                    break;
                case 4:
                    Input2Numbers(obj);
                    result = operations.Divide(obj.number1, obj.number2);
                    break;
                case 5:
                    Input2Numbers(obj);
                    result = operations.Percentage(obj.number1, obj.number2);
                    break;
                case 6:
                    Input2Numbers(obj);
                    result = operations.Exponent(obj.number1, obj.number2);
                    break;
                case 7:
                    Input1Number(obj);
                    result = operations.SquareRoot(obj.number1);
                    break;
                case 8:
                    Input1Number(obj);
                    result = operations.LogBaseE(obj.number1);
                    break;
                case 9:
                    Input1Number(obj);
                    result = operations.LogBase10(obj.number1);
                    break;
                case 10:
                    Input1Number(obj);
                    result = operations.Sine(obj.number1);
                    break;
                case 11:
                    Input1Number(obj);
                    result = operations.Cosine(obj.number1);
                    break;
                case 12:
                    Input1Number(obj);
                    result = operations.Tangent(obj.number1);
                    break;
                default:
                    Console.WriteLine(Properties.StringResource.InvalidOption);
                    break;
            }

            Console.WriteLine(Properties.StringResource.Result + result);


           
        }

        static void Input2Numbers(CalculatorDisplay obj)
        {
           
            Console.WriteLine(Properties.StringResource.Number1);
            obj.number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine(Properties.StringResource.Number2);
            obj.number2 = Double.Parse(Console.ReadLine());

        }
        static void Input1Number(CalculatorDisplay obj)
        {
            Console.WriteLine(Properties.StringResource.Number1);
            obj.number1 = Double.Parse(Console.ReadLine());
        }
    }
}
