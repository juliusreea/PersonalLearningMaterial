using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal class Audi : Car
    {
        public bool IsQuattro;
        public Audi(bool isQuattor, string name, int fuel, int tank, string model) : base(name, fuel, tank, model)
        {
            isQuattor = isQuattor;
        }
    }
}
