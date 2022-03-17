using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantOrderingApp.Models;
using System.IO;

namespace RestaurantOrderingApp.Functionality
{
    public class FileService
    {
        public readonly string _path = @"C:\Users\Dell\source\repos\PersonalLearningMaterial\RestaurantOrderingApp\CSVfiles\";
        public List<Drink> ReadDrinksFromFile(string fileName)
        {
            string path = $"{_path}{fileName}.csv";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();

            List<Drink> drinks = new List<Drink>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                Drink drinkData = new();
                drinkData.Name = parts[0];
                drinkData.Price = Convert.ToDecimal(parts[1]);
                drinks.Add(drinkData);
            }
            return drinks;
        }
        public List<Food> ReadFoodsFromFile(string fileName)
        {
            string path = $"{_path}{fileName}.csv";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();

            List<Food> foods = new List<Food>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                Food foodData = new();
                foodData.Name = parts[0];
                foodData.Price = Convert.ToDecimal(parts[1]);
                foods.Add(foodData);
            }
            return foods;
        }
        
        public Order DrinksParse(Drink drink)
        {
            Order order = new Order();
            order.Name = ReadDrinksFromFile("Drinks")[0].Name;
            order.Price = ReadDrinksFromFile("Drinks")[0].Price;
            return order;
        }
        public Order FoodsParse(Food food)
        {
            Order order = new Order();
            order.Name = ReadFoodsFromFile("Foods")[0].Name;
            order.Price = ReadFoodsFromFile("Foods")[0].Price;
            return order;
        }
    }
}
