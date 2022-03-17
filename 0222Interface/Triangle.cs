using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Triangle : IPolygon
    {
        public double Side;
        public double Height;

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }
        public double GetArea()
        {
            return (Side * Height) / 2;
        }
    }
}
