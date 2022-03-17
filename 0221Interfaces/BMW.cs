using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal class BMW : Car
    {
        public bool IsQuattro;
        public BMW(bool isquattro, string name, int fuel, int tank, string model) : base(name, fuel, tank, model)
        {
            IsQuattro = isquattro;
        }
    }
}
