using System;
using System.Collections.Generic;
using System.IO;

namespace RestaurantOrderingApp.Models
{
    public class CheckRestaurant : ICheck
    {
        public List<string> Orders { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Customer { get; set; }

        public CheckRestaurant()
        {
            Orders = new List<string>();
        }

        public readonly string _path = @"C:\Users\Dell\source\repos\PersonalLearningMaterial\RestaurantOrderingApp\CSVfiles\";
        public void PrintCheck(Table table)
        {
            foreach (var order in table.Orders)
            {
                Orders.Add($"{order.Name}, price: {order.Price}, items ordered: {order.Quantity}");
            }
            string path = $"{_path}RestaurantCheck.txt";
            File.WriteAllLines(path, Orders);
            File.AppendAllText(path, $"\n{DateTime.Now}");
            File.AppendAllText(path, $"\ntotal amount of {table.TotalAmount()} euro");
            File.AppendAllText(path, $"\n{table.Customers} persons were seated at {table}");
        }
    }
}