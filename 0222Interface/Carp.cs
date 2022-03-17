using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Carp : IAnimal, IFIsh
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaximumOffspring { get; set; }
        public bool SaltWater { get; set; }

        public Carp(string name, string description, int maximumOffspring, bool saltWater)
        {
            Name = name;
            Description = description;
            MaximumOffspring = maximumOffspring;
            SaltWater = saltWater;
        }

        public void Eat()
        {

        }
        public void Breed()
        {

        }
        public void Swim()
        {

        }
    }
}
