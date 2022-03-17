using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaximumOffspring { get; set; }

        public Cat(string name, string description, int maximumOffspring)
        {
            Name = name;
            Description = description;
            MaximumOffspring = maximumOffspring;
        }
        public void Eat()
        {

        }
        public void Breed()
        {

        }
        public void GiveBirth()
        {

        }
    }
}
