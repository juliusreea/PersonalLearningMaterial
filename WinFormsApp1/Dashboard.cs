using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemo();
        }
        private void PopulateCartWithDemo()
        {
            cart.List.Add(new ProductModel("Cereal", 3.63M));
            cart.List.Add(new ProductModel("Milk", 2.95M));
            cart.List.Add(new ProductModel("Strawberries", 7.51M));
            cart.List.Add(new ProductModel("Blueberries", 8.84M));
        }

        private void messageBoxButtonDemo_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(ShowTotalAlert, CalculateLeveledDiscount, 
                ShowItemsInCart, PrintOutDiscountAlert);
            MessageBox.Show($"the total of cart is {total}");
        }


        private void textBoxButtonDemo_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((subTotal) => textBox1.Text = $"{subTotal:C2}", (products, subTotal) =>
            subTotal - (products.Count * 2), (products) => { },
            (message) => { });

            textBox2.Text = $"{total}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }
        private void ShowTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"Subtotal is {subTotal}");
        }
        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count;
        }
        private void ShowItemsInCart(List<ProductModel> products)
        {
            var message = string.Join(Environment.NewLine, products);
            MessageBox.Show(message);

        }

    }
}
