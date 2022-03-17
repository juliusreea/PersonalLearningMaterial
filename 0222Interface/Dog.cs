using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Dog:IAnimal,IMammal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaximumOffspring { get; set; }

        public Dog(string name, string description, int maximumOffspring)
        {
            Name = name;
            Description = description;
            MaximumOffspring = maximumOffspring;
        }

        public void Eat()
        {
            Console.WriteLine("auau");
        }
        public void Breed()
        {

        }
        public void GiveBirth()
        {

        }
    }
}
