using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215Linq
{
    internal class PersonWithPet
    {
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }

        public PersonWithPet(string name, List<Pet> pets)
        {
            Name = name;
            Pets = pets;
        }
    }
}
