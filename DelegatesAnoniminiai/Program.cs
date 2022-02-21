using System;
using System.Collections.Generic;
using DelegatesAnoniminiai.Printer;

namespace DelegatesAnoniminiai
{
    internal class Program
    {
        public delegate void NameProvide(string firstName, string lastName, string age);

        public delegate int MultiplyNumbers(int number1, int number2);

        public delegate List<int> ListSteps(List<int> list, int step);

        public delegate string IdentifyType<T>(T element);

        static void Main(string[] args)
        {
            //delegatai
            
            NameProvide prov = delegate (string firstName, string lastName, string age)//anoniminis
            {
                Console.WriteLine($"{firstName}, {lastName}, {age}");
            };
            prov("julius", "vaigauskas", "35");//anoniminis
            var nameProvide = new NameProvide(PrintName);//paprastas
            nameProvide("julius", "vaigauskas", "35");//paprastas
            MultiplyNumbers mult = delegate (int number1, int number2)// anoniminis
            {
                return number1 * number2;
            };
            mult(2, 3).Printer();//anoniminis
            var multiplyNumbers = new MultiplyNumbers(NumberContainer);//paprastas
            multiplyNumbers(2,3).Printer();//paprastas
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };//paprastas
            var listSteps = new ListSteps(ListStepProvide);//paprastas
            listSteps(list, 4).Printer();//paprastas
            ListSteps listSteps2 = delegate (List<int> list, int step)//anoniminis
            {
                var newList = new List<int>();
                for (int i = 0; i < list.Count; i += step)
                {
                    newList.Add(list[i]);
                }
                return newList;
            };
            listSteps2(list, 2).Printer();//anoniminis

            var identifyType = new IdentifyType<int>(GetType);//paprastas
            identifyType(6).Printer();//paprastas


            IdentifyType<int> identifyType1 = delegate (int element)//anonnimis
            {
                return element.GetType().ToString();
            };
            identifyType(7).Printer();//anoniminis


        }
        public static void PrintName(string firstName, string lastName, string age)
        {
            Console.WriteLine($"{firstName.ToUpper()} {lastName}, {age}");
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
