using DemoLibrary;
using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    public class Program
    {
        
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemo();
            Functionalities functionalities = new Functionalities();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(TotalAmountIs, functionalities.CalculateLeveledDiscount, functionalities.CartViewer, AlertUser):C2}");

            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"total for cart it {subTotal}"),
                (products, subTotal) =>
                {
                    if (products.Count > 3)
                    {
                        return subTotal * 0.5M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                (products) =>
                {
                    foreach(var product in products)
                    {
                        Console.WriteLine($"{product.Name}");
                    }
                },(message)=>Console.WriteLine(message));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit application");
            Console.ReadKey();
        }
        public static void TotalAmountIs(decimal totalAmount)
        {
            Console.WriteLine($"Total amount is {totalAmount:C2}");
        }
        public static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }
        

        public static void PopulateCartWithDemo() 
        {
            cart.List.Add(new ProductModel("Cereal", 3.63M));
            cart.List.Add(new ProductModel("Milk", 2.95M));
            cart.List.Add(new ProductModel("Strawberries", 7.51M));
            cart.List.Add(new ProductModel("Blueberries", 8.84M));
        }
    }
}
