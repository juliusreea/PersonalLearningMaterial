using System;

namespace ATM.Extensions
{
    static class ProgramBase 
    {
        public static void Printer(this string input)
        {
            Console.WriteLine(input);
        }
    }
}