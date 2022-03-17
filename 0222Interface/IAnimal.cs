using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal interface IAnimal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Eat();
        public void Breed();
    }
}
