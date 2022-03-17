using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Hexagon : IPolygon
    {
        public double Side;

        public Hexagon(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return ((3*Math.Sqrt(3))/2)*Math.Pow(2, Side);
        }
    }
}
