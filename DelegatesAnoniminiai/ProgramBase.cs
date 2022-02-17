using System;
using System.Collections.Generic;

namespace DelegatesAnoniminiai.Printer
{
    public static class ProgramBase
    {
        public static void Printer(this string input)
        {
            Console.WriteLine(input);
        }
        public static void Printer(this int input)
        {
            Console.WriteLine(input);
        }
        public static void Printer(this List<int> input)
        {
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
        }

    }
}