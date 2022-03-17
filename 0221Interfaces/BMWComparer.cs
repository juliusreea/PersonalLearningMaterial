using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221Interfaces
{
    internal class BMWComparer : IComparer<BMW>
    {
        public int Compare(BMW x, BMW y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
