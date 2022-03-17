using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal class AudiComparer : IComparer<Audi>
    {
        public int Compare(Audi x, Audi y)
        {
            return x.Fuel.CompareTo(y.Fuel);    
        }

    }
}
