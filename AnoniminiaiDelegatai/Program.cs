using System;

namespace AnoniminiaiDelegatai
{
    internal class Program
    {
        public delegate string NameProvide(string firstName, string lastName, string age);

        public delegate int MultiplyNumbers(int number1, int number2);

        static void Main(string[] args)
        {
            WriteName(delegate ("julius", "vaigauskas", "1985")
            { 

            };
            NumberContainer(delegate (int number1, int number2)
            {
                Console.WriteLine(number1);
            }); ;
        }
        public static void WriteName(NameProvide nameProvide)
        {
            nameProvide("julius", "vaigauskas", "1985");
        }
        public static int NumberContainer(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
