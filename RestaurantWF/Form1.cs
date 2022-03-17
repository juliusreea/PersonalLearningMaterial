using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using RestaurantOrderingApp.OrderRepo;
using RestaurantOrderingApp.Models;
using RestaurantOrderingApp.Functionality;
using System.Windows.Forms;

namespace RestaurantWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drinksList1.Hide();
            foodList1.Hide();
            table11.Hide();
        }

        private void DrinksList_Click(object sender, EventArgs e)
        {
            foodList1.Hide();
            drinksList1.Show();
        }

        private void FoodList_Click(object sender, EventArgs e)
        {
            drinksList1.Hide();
            foodList1.Show();
        }

        private void orderListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
