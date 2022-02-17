using _0215ExtensionMethods.Extentsions;
using System;
using _0215ExtensionMethods.UzduociuExtensions;
using System.Collections.Generic;

namespace _0215ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (-2).IsValuePositive().PrintToConsole();
            9.IsValueEven().PrintToConsole();
            ("juliusVaigauskas", "1986", "gmail.com").PrintEmail().PrintToConsole();

                "grybu karas".IsThereSpacesInSentence().PrintToConsole();
            "this is demo".PrintToConsole();
            var list = new List<int> (new[] { 1, 2, 3, 4, 5, 6});
            list.FindAndReturnIfEqual(2).PrintToConsole();
            list.EveryOtherWord().PrintToConsole();

            ISimpleLogger logger = new SimpleLogger();
            logger.LogError("this is an error");
            logger.LogWarning("this is a warning");
            Console.WriteLine("goodbye");
        }
        
    }
    public static class ExtendSimpleLogger
    {
        public static void LogError(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");

            Console.ForegroundColor = defaultColor;
        }
        public static void LogWarning(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");

            Console.ForegroundColor = defaultColor;
        }
    }
    public class SimpleLogger : ISimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType} : {message}");
        }
    }

}
