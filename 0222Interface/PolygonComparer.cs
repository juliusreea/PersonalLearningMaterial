using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class PolygonComparer : IComparer<IPolygon>
    {
        public int Compare(IPolygon x, IPolygon y)
        {
            return x.GetArea().CompareTo(y.GetArea());
        }
    }
}
