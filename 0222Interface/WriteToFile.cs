using System.Collections.Generic;
using System.IO;

namespace _0222Interface
{
    internal class WriteToFiles : IWriteableToFile<List<IPolygon>, List<IAnimal>>
    {
        public void WriteToFile(List<IPolygon> input)
        {
            string _path = @$"C:\Users\Dell\source\repos\PersonalLearningMaterial\0222Interface\{input.GetType().Name}.txt";
            File.WriteAllText(_path, input.GetType().Name);
            foreach (var polygon in input)
            {
                File.AppendAllText(_path, $"\n {polygon.GetType().Name}");
                File.AppendAllText(_path, $"\n Area is {polygon.GetArea()}");
            }
            
        }
        public void WriteToFileAnimals(List<IAnimal> input)
        {
            string _path = @$"C:\Users\Dell\source\repos\PersonalLearningMaterial\0222Interface\{input.GetType().Name}.txt";
            File.WriteAllText(_path, input.GetType().Name);
            foreach(var animal in input)
            {
                File.AppendAllText(_path, $" {animal.Name}");
                File.AppendAllText(_path, $"\n this is {animal.Description}");
            }

            
        }
    }
}
