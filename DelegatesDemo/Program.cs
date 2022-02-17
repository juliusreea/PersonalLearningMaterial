using DemoLibrary;
using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    internal class Program
    {
        
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemo();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(TotalAmountIs):C2}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit application");
            Console.ReadKey();
        }
        public static void TotalAmountIs(decimal totalAmount)
        {
            Console.WriteLine($"Total amount is {totalAmount:C2}");
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
