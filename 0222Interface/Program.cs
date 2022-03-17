using System;
using System.Collections.Generic;

namespace _0222Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositoryOfAllSpecies allSpecies = new RepositoryOfAllSpecies();
            //allSpecies.AllAnimals.Add(new Dog("Husky", "pullDog", 2));
            //allSpecies.AllAnimals.Add(new Dog("Retriever", "FamilyDog", 3));
            //allSpecies.AllAnimals.Add(new Dog("Zehnenehund", "Resque", 6));
            //allSpecies.AllAnimals.Add(new Dog("Newfoundland", "Resque", 1));
            //allSpecies.AllMammals.Add(new Cat());
            allSpecies.Allfish.Add(new Carp("carp1", "nice1", 4, false));
            allSpecies.AllAnimals.Add(new Carp("carp2", "nice2", 4, true));
            allSpecies.AllAnimals.Add(new Carp("carp3", "nice2", 6, true));
            allSpecies.AllAnimals.Add(new Carp("carp4", "nice4", 3, false));
            allSpecies.AllAnimals.Add(new Bass("Bass1", "sticky1", 2, false));
            allSpecies.AllAnimals.Add(new Bass("Bass2", "sticky2", 2, true));
            allSpecies.AllAnimals.Add(new Bass("Bass3", "sticky3", 2, false));
            allSpecies.AllAnimals.Add(new Bass("Bass4", "sticky14", 2, false));

            IPolygon hexagon = new Hexagon(4);
            Console.WriteLine(hexagon.GetArea());
            IPolygon pentagod = new Pentagod(4);
            Console.WriteLine(pentagod.GetArea());
            IPolygon quadrilateral = new Quadriteral(4,4,6);
            Console.WriteLine(quadrilateral.GetArea());
            IPolygon triangle = new Triangle(4, 4);
            Console.WriteLine(triangle.GetArea());

            List<IPolygon> polygons = new List<IPolygon>();
            polygons.Add(pentagod);
            polygons.Add(quadrilateral);
            polygons.Add(triangle);
            polygons.Add(hexagon);

            PolygonComparer polygonComparer = new PolygonComparer();
            polygons.Sort(polygonComparer);

            polygons.ForEach(polygon => Console.WriteLine(polygon.GetArea()));
            WriteToFiles writeToFiles = new WriteToFiles();
            writeToFiles.WriteToFile(polygons);
            writeToFiles.WriteToFileAnimals(allSpecies.AllAnimals);

        }
    }
}
