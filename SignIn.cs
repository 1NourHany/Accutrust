using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace Test_Lab_System
{
    public partial class SignIn : Form
    {
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=testlabsystem;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
        public void searchData(string valueToSearch , string valueToSearch2, string valueToSearch3)
        {
            string query = "SELECT * FROM EMPLOYEE WHERE CONCAT(EmployeeEmail, EmployeePassword,EmployeePosition) like '%" + valueToSearch + valueToSearch2 + valueToSearch3+ "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            if (dataGridView1.Rows.Count > 1)
            {
                MessageBox.Show("Email and Password and Title are valid.");
                if (comboBox1.Text == "Admin")
                {
                this.Hide();
                 //this.Close();
                AdminView f1 = new AdminView();
                f1.Show();
                }
                else if (comboBox1.Text == "Registrar")
                {
                    this.Hide();
                 //   this.Close();
                    Registrar__Navigation_Screen f4 = new Registrar__Navigation_Screen();
                    f4.Show();
                }
                else if (comboBox1.Text == "Finance Staff")
                {
                    this.Hide();
                    this.Close();
                    TestPayment f5 = new TestPayment();
                    f5.Show();
                }
                else if (comboBox1.Text == "Logistics Staff")
                {
                    this.Hide();
                    PurchaseOrder f6 = new PurchaseOrder();
                    f6.Show();
                }
                else if (comboBox1.Text == "Doctor")
                {
                    this.Hide();
                    Results f7 = new Results();
                    f7.Show();
                }

            }
            else
            {
                MessageBox.Show("Email or Password or Title is incorrect,please try again!");
                textemail.Clear();
                textpassword.Clear();
                textemail.Focus();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textemail.Text.ToString();
            string valueToSearch2 = textpassword.Text.ToString();
            string valueToSearch3 = comboBox1.Text.ToString();
            searchData(valueToSearch, valueToSearch2, valueToSearch3);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void title_click(object sender, EventArgs e)
        {

        }

        private void Signin_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
