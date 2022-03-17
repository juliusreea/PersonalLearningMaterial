using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Pentagod : IPolygon
    {
        public double Side;

        public Pentagod(double side)
        {
            Side = side;
        }
        public double GetArea()
        {
            
            return Math.Sqrt(5*(5 + (2 * Math.Sqrt(5))))*Math.Pow(2, Side)*0.25;
        }
        public override string ToString()
        {
            return $" area of pentagon is {GetArea()}";
        }
    }
}
