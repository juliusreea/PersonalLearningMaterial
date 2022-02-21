using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Functionalities
    {
        public decimal CalculateLeveledDiscount(List<ProductModel> list, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.8M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 20)
            {
                return subTotal * 0.9M;
            }
            else
            {
                return subTotal;
            }
        }
        public void CartViewer(List<ProductModel> list)
        {
            Console.WriteLine($"These are producs in your cart:");
            foreach (ProductModel product in list)
            {
                Console.WriteLine($"{product.Name}, {product.Price}");
            }
        }
    }
}
