using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class Calculator
    {
        internal void AdditionSubtractionMultiplicationDivision<T1, T2>(T1 input, T2 input2)
        {
            double addition;
            double subtraction;
            double multiplication;
            double division;
            var number1 = Convert.ToDouble(input);
            var number2 = Convert.ToDouble(input2);
            addition = number1 + number2;
            subtraction = number1 - number2;
            multiplication = number1 / number2;
            division = number1 * number2;
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
        }
        internal void Validation<T1, T2>(T1 input, T2 input2)
        {
            dynamic number = input;
            dynamic number2 = input2;
            if (double.TryParse(number, out double result) && double.TryParse(number2, out double result2))
            {
                Console.WriteLine("all good");
            }
            else
            {
                Console.WriteLine("input incorrect");
            }
        }
    }
}
