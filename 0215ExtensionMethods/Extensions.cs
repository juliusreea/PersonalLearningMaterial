using System;
using System.Collections.Generic;

namespace _0215ExtensionMethods.Extentsions
{
    public static class Extensions
    {

        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintToConsole(this int value)
        {
            Console.WriteLine(value);
        }
        public static void PrintToConsole(this bool value)
        {
            Console.WriteLine(value);
        }
        public static void PrintToConsole(this List<int> list)
        {
            foreach (int i in list)
            Console.WriteLine(i);
        }
    }

}
