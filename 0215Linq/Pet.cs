using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215Linq
{
    internal class Pet
    {
        public string Name { get; set; }
        public int Age;

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
