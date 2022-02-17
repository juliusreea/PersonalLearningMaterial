using System;
using System.Collections.Generic;
using System.Linq;

namespace _0215Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Sukurkite sąrašą su skaičiais. Sukurkite naują sąrašą ir jo reikšmei priskirkite pirmojo sąrašo Select grąžintą sąrašą.
//            Select metodas turi pakelti kiekvieną pirmojo sąrašo skaičių kvadratu.
//Sukurkite sąraša teigiamų ir neigiamų elementų, sukurkite naują sąrašą iš jo su LINQ grąžinant tik teigiamus skaičius.
//Sukurkite sąraša teigiamų ir neigiamų elementų, sukurkite naują sąrašą iš jo su LINQ grąžinant tik teigiamus skaičius kurie ne didesni už 10.
//Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį didėjančia tvarka.
//Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį mažėjančia tvarka.
//Suraskite iš skaičių sąrašo didžiausią elementą naudodami LINQ.
//Sukurkite klasę Person su parametrais Name ir Age, sukurkite sąrašą iš šių objektų.
//Sukurkite naują sąrašą su LINQ paimdami tik žmonių vardus, kitą sąrašą tik iš amžiaus.
//Surūšiuokite sąrašą pagal amžių mažėjančia tvarka.
//Sukurkite naują sąrašą iš žmonių, kurių vardai prasideda iš A raidės.
//Sukurkite naują sąrašą iš žmonių, kurių amžius yra virš 40 ir surūšiuokit pagal vardą.

            var list = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, });
            var list2 = list.Select(x => x*x);
            foreach(var item in list2)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            var list3 = new List<int>(new[] { 6, 2, 3, (-4), -5, 6, 7, 0, });
            var list4 = list3.Where(x => x > 0);
            foreach (var item in list4)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            var list5 = new List<int>(new[] { 6, 20, 3, (-4), -5, 60, 7, -8, });
            var list6 = list5.Where(x => x > 0).Where(x => x<10);
            foreach (var item in list6)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            var list7 = new List<int>(new[] { 6, 20, 3, (-4), -5, 60, 7, -8, });
            var list8 = list7.OrderBy(x => x);
            foreach (var item in list8)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
            var list9 = new List<int>(new[] { 6, 20, 3, (-4), -5, 60, 7, -8, });
            var list10 = list9.OrderByDescending(x => x);
            foreach (var item in list10)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
            var list11 = new List<int>(new[] { 6, 20, 3, (-4), -5, 60, 7, -8, });
            var value = list11.Max();
            Console.WriteLine(value);

            Console.WriteLine();
            var personList = new List<Person>();
            personList.Add(new Person("Adolf", 40));
            personList.Add(new Person("nick", 55));
            personList.Add(new Person("mike", 22));
            personList.Add(new Person("uosis", 78));
            personList.Add(new Person("titas", 12));

            var personListByName = personList.Select(person => person.Name).OrderBy(x=>x);
            foreach (var person in personListByName)
            {
                Console.Write($"{person}, ");
            }
            Console.WriteLine();
            var personListByAge = personList.Select(x => x.Age).OrderByDescending(x=>x);
            foreach (var person in personListByAge)
            {
                Console.Write($"{person}, ");
            }
            Console.WriteLine();
        }
    }
}
