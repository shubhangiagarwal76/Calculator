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
        
       

        static void Main(string[] args)
        {
            ResultCalculation calculation = new ResultCalculation();
            int option;
            String exit;

            do
            {
                Console.Clear();
                Console.WriteLine("***********" + Properties.StringResource.WelcomeMessage + "***********");
                Console.WriteLine("\t" + Properties.StringResource.Options);
                Console.WriteLine("1." + Properties.StringResource.BinaryOperations + "\n" + "2." + Properties.StringResource.UnaryOperations);
                Console.Write(Properties.StringResource.Choice);
                try
                {
         
                    option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("1." + Properties.StringResource.Add + "\n" +
                           "2." + Properties.StringResource.Subtract + "\n" +
                           "3." + Properties.StringResource.Multiply + "\n" +
                           "4." + Properties.StringResource.Divide + "\n" +
                           "5." + Properties.StringResource.Percent + "\n" +
                           "6." + Properties.StringResource.Exponent);
                            Console.Write("\t" + Properties.StringResource.Choice);
                            option = Int32.Parse(Console.ReadLine());
                            calculation.Input2Numbers(option);
                            break;

                        case 2:
                            Console.WriteLine(
                            "1." + Properties.StringResource.Sqrt + "\n" +
                            "2." + Properties.StringResource.Log + "\n" +
                            "3." + Properties.StringResource.Log10 + "\n" +
                            "4." + Properties.StringResource.Sin + "\n" +
                            "5." + Properties.StringResource.Cos + "\n" +
                            "6." + Properties.StringResource.Tan);
                            Console.Write("\t" + Properties.StringResource.Choice);
                            option = Int32.Parse(Console.ReadLine());
                            calculation.Input1Number(option);
                            break;

                        default:
                            Console.WriteLine(Properties.StringResource.InvalidOption);
                            break;
                            
                    }
                   
                    Console.WriteLine(Properties.StringResource.Result + calculation.result);


                }
                catch(FormatException e)
                {
                    Console.WriteLine(Properties.StringResource.InvalidOption);
                }
                Console.WriteLine(Properties.StringResource.Exit);
                exit = Console.ReadLine();
            } while(exit.Equals("1"));
            Console.WriteLine(Properties.StringResource.GoodByeMessage);
        }
    }
}
