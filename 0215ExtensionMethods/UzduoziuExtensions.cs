using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215ExtensionMethods.UzduociuExtensions
{
    public static class UzduoziuExtensions
    {
        public static bool IsValuePositive(this int value)
        {
            bool result = (value > 0);
            return result;
        }
        public static bool IsValueEven(this int value)
        {
            bool result = (value % 2 == 0);
            return result;
        }
        public static bool IsThereSpacesInSentence(this string sentence)
        {
            bool result = sentence.Contains(" ");
            return result;
        }
        public static string PrintEmail(this string fullName, string yearOfBirth, string domain)
        {
            return $"{fullName}{yearOfBirth}@{domain}";
        }
        public static T FindAndReturnIfEqual<T>(this List<T> list, T value)
        {
            if (list.Contains(value))
            {
                return value;
            }
            else
            {
                return default;
            }
            
            
        }
        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            var list2 = new List<T>();
            for(int i =0; i < list.Count; i+=2)
            {
                list2.Add(list[i]);
            }
            return list2;
        }
        public static string EverySecondLine(this string path)
        {
            var lines = System.IO.File.ReadAllLines(path);
            List<string> lines2 = new List<string>();
            for(int i =0; i < lines.Length; i +=2)
            {
                lines2.Add(lines[i]);
            }
            return lines2.ToString();
        }
    }
}
