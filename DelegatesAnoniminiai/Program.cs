using System;
using System.Collections.Generic;
using DelegatesAnoniminiai.Printer;

namespace DelegatesAnoniminiai
{
    internal class Program
    {
        public delegate string NameProvide(string firstName, string lastName, string age);

        public delegate int MultiplyNumbers(int number1, int number2);

        public delegate List<int> ListSteps(List<int> list, int step);

        public delegate string IdentifyType<T>(T element);

        static void Main(string[] args)
        {
            //delegatai
            var nameProvide = new NameProvide(PrintName);
            nameProvide("julius", "vaigauskas", "35").Printer();
            var multiplyNumbers = new MultiplyNumbers(NumberContainer);
            multiplyNumbers(2,3).Printer();
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var listSteps = new ListSteps(ListStepProvide);
            listSteps(list, 4).Printer();
            var identifyType = new IdentifyType<string>(GetType);
            identifyType("gu").Printer();
            //anoniminiai delegatai tas pats

        }
        public static string PrintName(string firstName, string lastName, string age)
        {
            return $"{firstName} {lastName}, {age}";
        }
        public static int NumberContainer(int number1, int number2)
        {
            return number1 * number2;
        }
        public static List<int> ListStepProvide(List<int> list, int step)
        {
            var newList = new List<int>();
            for (int i = 0; i < list.Count; i += step)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
        public static string GetType<T>(T element)
        {
            return element.GetType().ToString();
        }

    }
}
