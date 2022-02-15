using System;
using System.Collections.Generic;

namespace _0208PamokaGenerics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //showitem
            ShowItems("hi", 5.0m);

            //validation
            string val = string.Empty;

            var value = new Random().Next(1, 10) >= 5 ? new Human("titas", "piragis") : null;
            Validate(value);
            Validation.Validate(value);
            //list.array
            //uzduotis2
            FourSIdeGeometricFigure fourSIdeGeometricFigure = new FourSIdeGeometricFigure("bokstas", 12, 13);
            fourSIdeGeometricFigure.GetArea();
            Generator generator = new Generator();
            generator.Show(fourSIdeGeometricFigure);


            //uzduotis 3
            Calculator calculator = new Calculator();
            //calculator.Validation(2,3);
            calculator.AdditionSubtractionMultiplicationDivision(13d, 9m);

            //uzduotis 4
            
            TeamRepository teamRepository = new TeamRepository();
            
            teamRepository.AddTeam(new Team("lavonai", 1, 8));
            teamRepository.AddTeam(new Team("Maladec bahurai", 6, 1));
            teamRepository.AddTeam(new Team("Rokiskio suris", 2, 4));
            teamRepository.AddTeam(new Team("Alytaus aliuminiai", 3, 3));
            teamRepository.AddTeam(new Team("BC geriau nereikia", 2, 4));
            teamRepository.AddTeam(new Team("suvazineti", 0, 12));

            TeamFunctionality teamFunctionality = new TeamFunctionality();
            teamFunctionality.TeamPrinter(teamRepository);

            //uzduotis 4

            //uzduotis 6

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            GenericsColections<int> genericsColections = new(numbers);
            genericsColections.PrintList();

            var number = genericsColections.FindValue(10, numbers);
            Console.WriteLine(number);

            var number2 = genericsColections.FindValue2(3, numbers);
            Console.WriteLine(number2);

            bool check = genericsColections.CheckIfValueExists(18, numbers);
            Console.WriteLine(check);

        }
        public static void ShowItems<T1, T2>(T1 input, T2 input2)
        {
            Console.WriteLine(input);
            Console.WriteLine(input2);
        }
        public class Human
        {
            private readonly Func<string> _outputProvider;
            public string Name { get; set; }
            public string LastName { get; set; }

            public Human(string name, string lastName)
            {
                Name = name;
                LastName = lastName;
            }

            public override string ToString()
            {
                return $"{Name} {LastName}";
            }
        }

        public static void Validate<T>(T inputValue)
        {
            if (inputValue == null)
            {
                Console.WriteLine("input is null");
            }
            else
            {
                Console.WriteLine(inputValue);
            }
        }
        

    }
    public class Validation
    {
        public static void Validate<T>(T inputValue)
        {
            if (inputValue == null)
            {
                Console.WriteLine("value is null");
            }
            else
            {
                Console.WriteLine("viskas ok");
            }
            
        }
    }
   

}
