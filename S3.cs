using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lab_System
{
    public partial class S3 : Form
    {
        public S3()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public int searchSalary()
        {
            string query = " SELECT SUM(employeesalary) FROM employee; ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
            string cell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // label3.Text = cell;
            int celll = Convert.ToInt16(cell);

            return celll;

            //string query = "SELECT SUM(employeesalary) FROM employee;";
            //command = new MySqlCommand(query, connection);
            //adapter = new MySqlDataAdapter(command);
            //table = new DataTable();
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;
            //int firstRowIndex = dataGridView1.SelectedRows.Count - 1;
            //string cell = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //int celll = Convert.ToInt16(cell);
            //return celll;
        }
        public int searchTest()
        {
            string x = " SELECT SUM(TotalPay) FROM tests where (AppointmentMonth =" + textBox1.Text + ");";

            string query = x;
            command = new MySqlCommand(query, connection);
            command.Parameters.Add("@param6", MySqlDbType.VarChar);
            command.Parameters["@param6"].Value = textBox1.Text.ToString();
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            int firstRowIndex = dataGridView2.SelectedRows.Count - 1;
            string cell = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            // label3.Text = cell;
            int celll = Convert.ToInt16(cell);

            return celll;

            //string query = " SELECT SUM(TotalPay) FROM tests;";
            //command = new MySqlCommand(query, connection);
            //adapter = new MySqlDataAdapter(command);
            //table = new DataTable();
            //adapter.Fill(table);
            //dataGridView3.DataSource = table;
            //int firstRowIndex = dataGridView2.SelectedRows.Count - 1;
            //string cell = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //int celll = Convert.ToInt16(cell);
            //return celll;
           // string query = " SELECT SUM(TotalPay) FROM tests where (AppointmentMonth =  9)";
            
           // command = new MySqlCommand(query, connection);
          //  adapter = new MySqlDataAdapter(command);
            //table = new DataTable();
            //adapter.Fill(table);
            //dataGridView2.DataSource = table;
            //int firstRowIndex = dataGridView2.SelectedRows.Count - 1;
            //string cell = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //int celll = Convert.ToInt16(cell);
            //return celll;
        }
        public int searchOrderPrices()
        {
            string query = " SELECT SUM(TotalPrice) FROM LOGISTICS; ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
            int firstRowIndex = dataGridView3.SelectedRows.Count - 1;
            string cell = dataGridView3.CurrentRow.Cells[0].Value.ToString();
           // label3.Text = cell;
            int celll = Convert.ToInt16(cell);

             return celll;
        }
        private void S3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = searchTest();
            label4.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           int x =searchSalary();
           label3.Text = x.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int salarytotal= searchSalary();
            int Testtotal = searchOrderPrices();
           int totalexpense = searchOrderPrices() + searchSalary();
            label6.Text = totalexpense.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //searchOrderPrices();
           int x =searchOrderPrices();
          label5.Text = x.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
