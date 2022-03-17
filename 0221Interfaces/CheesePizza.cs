using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal class CheesePizza : Ipizza
    {
        public void Prepare()
        {
            Console.WriteLine("preparing cheese pizza");
        }
    }
}
