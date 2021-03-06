using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ProductModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} {Price}";
        }
    }
}
