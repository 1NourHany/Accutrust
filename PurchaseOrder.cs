using System;
using Test_Lab_System.Models;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace Test_Lab_System
{
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            LOGISTICS Order = new LOGISTICS();
            Order.CompanyName = textBox1.Text;
            Order.PhoneNum = textBox2.Text;
            Order.Email = textBox3.Text;
            Order.RequestDate = dateTimePicker1.Text;
            Order.DeliveryDate = dateTimePicker2.Text;
            Order.Prodcut = Product.Text;
            Order.Quantity = Quantity.Text;
            Order.TotalPrice = Check();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=testlabsystem;uid=root;pwd=123456789");
            MySqlCommand cmd = null;
            conn.Open();

            string cmdString = "insert into LOGISTICS(OrderID,CompanyName ,PhoneNum , Email, RequestDate, DeliveryDate ,Prodcut,Quantity, TotalPrice)" +
                "values(TO_BASE64(RANDOM_BYTES(5)),@param1, @param2 , @param3, @param4, @param44, @param5, @param6, @param7);";
            cmd = new MySqlCommand(cmdString, conn);


            cmd.Parameters.Add("@param1", MySqlDbType.VarChar);
            cmd.Parameters["@param1"].Value = Order.CompanyName.ToString();
            cmd.Parameters.Add("@param2", MySqlDbType.VarChar);
            cmd.Parameters["@param2"].Value = Order.PhoneNum.ToString();
            cmd.Parameters.Add("@param3", MySqlDbType.VarChar);
            cmd.Parameters["@param3"].Value = Order.Email.ToString();
            cmd.Parameters.Add("@param4", MySqlDbType.VarChar);
            cmd.Parameters["@param4"].Value = Order.RequestDate.ToString();
            cmd.Parameters.Add("@param44", MySqlDbType.VarChar);
            cmd.Parameters["@param44"].Value = Order.DeliveryDate.ToString();
            cmd.Parameters.Add("@param5", MySqlDbType.VarChar);
            cmd.Parameters["@param5"].Value = Order.Prodcut.ToString();
            cmd.Parameters.Add("@param6", MySqlDbType.VarChar);
            cmd.Parameters["@param6"].Value = Order.Quantity.ToString();
            cmd.Parameters.Add("@param7", MySqlDbType.VarChar);
            cmd.Parameters["@param7"].Value = Order.TotalPrice.ToString();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Data Stored Successfully");
        }
        public string Check()
        {
            if (Product.Text == "Cotton")
            {
                int quantity=Convert.ToInt16(Quantity.Text);
                int price = 50 * quantity;
                
                string x=price.ToString();
                textBox4.Text = x;
                return x;
                
            }
            else if (Product.Text == "Gloves")
            {
                int quantity = Convert.ToInt16(Quantity.Text);
                int price = 100 * quantity;

                string x = price.ToString();
                textBox4.Text = x;
                return x;
            }
            else if (Product.Text == "Test Tubes")
            {
                int quantity = Convert.ToInt16(Quantity.Text);
                int price = 150 * quantity;

                string x = price.ToString();
                textBox4.Text = x;
                return x;
            }
            else if (Product.Text == "Syringe")
            {
                int quantity = Convert.ToInt16(Quantity.Text);
                int price = 130 * quantity;

                string x = price.ToString();
                textBox4.Text = x;
                return x;
            }
            return "0";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
