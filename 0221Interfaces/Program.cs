using System;
using System.Collections.Generic;
using _0221Interfaces.Funtionality;

namespace _0221Interfaces
{


    internal class Program 
    {

        static void Main(string[] args)
        {
            var pizzas = new List<Ipizza> { new NewYorkPizza(), new CheesePizza() };

            pizzas.ForEach(pizza => pizza.Prepare());



            var newBmwList = new List<BMW> { new BMW(true, "bmw", 20, 60, "thirdSeries"), new BMW(true, "bmw", 40, 70, "fifthSeries"), new BMW(true, "bmw", 30, 80, "seventhSeries") };
            var newAudiList = new List<Audi> { new Audi(true, "audi", 20, 60, "a3"), new Audi(false, "audi", 40, 70, "a5"), new Audi(true, "audi", 30, 80, "a7") };

            var bmwComparer = new BMWComparer();
            var audiComparer = new AudiComparer();
            newBmwList.Sort(bmwComparer);
            newAudiList.Sort(audiComparer);
            foreach(var bmw in newBmwList)
            {
                Console.WriteLine($"{ bmw.Model}");
            }
            foreach (var audi in newAudiList)
            {
                Console.WriteLine($"{ audi.Tank}");
            }
            //foreach (var car in )
            newBmwList[1].Drive().Printer("yes");
            newBmwList[0].Refuel(20);

        }
    }
}
