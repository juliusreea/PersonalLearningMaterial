using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class FourSIdeGeometricFigure
    {
        public string Name;
        public double Base { get; set; }

        public double Height;

        public FourSIdeGeometricFigure(string name, double @base, double height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public FourSIdeGeometricFigure()
        {
        }

        public void GetArea()
        {
            var area = Base * Height;
            Console.WriteLine(area);
        }
        public double Area()
        {
            var area = Base * Height;
            return area;
        }

        public override string ToString()
        {
            return $"{Name}, base value is {Base}, height is {Height} and area is {Area()}";
        }
    }
    internal class Generator
    {
        internal void Show<T>(T printValue)
        {
            Console.WriteLine(printValue);
        }
    }
}