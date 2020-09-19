﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapecity.Internship.Assignment.Calculator.lib
{
    public class ScientificOperations : ArithmeticOperations
    {
        public double Negate(double num1)
        {
            return -num1;
        }

        public double LogBase10(double num1)
        {
            return Math.Log10(num1);
        }

        public double LogBaseE(double num1)
        {
            return Math.Log(num1);
        }



        public double DegreeToRadian(double num1)
        {
            num1 = (num1 * Math.PI) / 180;
            return num1;
        }

        public double Sine(double num1)
        {
            num1 = DegreeToRadian(num1);
            return Math.Sin(num1);
        }

        public double Cosine(double num1)
        {
            num1 = DegreeToRadian(num1);
            return Math.Cos(num1);
        }

        public double Tangent(double num1)
        {
            num1 = DegreeToRadian(num1);
            return Math.Tan(num1);
        }

        public double SquareRoot(double num1)
        {
            return Math.Sqrt(num1);
        }

        public double Reciprocal(double num1)
        {
            return 1.0 / num1;
        }
    }
}
