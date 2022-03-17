using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0222Interface
{
    internal class Quadriteral : IPolygon
    {
        public double Height1;
        public double Height2;
        public double Diameter;

        public Quadriteral(double height1, double height2, double diameter)
        {
            Height1 = height1;
            Height2 = height2;
            Diameter = diameter;
        }

        public double GetArea()
        {
            return 0.25 * Diameter * (Height1 * Height2);
        }
    }
}
