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
        public void searchData(string valueToSearch , string valueToSearch2)
        {
            string query = "SELECT * FROM EMPLOYEE WHERE CONCAT(EmployeeEmail, EmployeePassword) like '%" + valueToSearch + valueToSearch2 + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            if (dataGridView1.Rows.Count > 1)
            {
                MessageBox.Show("Email and Password are valid.");                
                this.Hide();
                new_exising_patient f4 = new new_exising_patient();
                f4.Show();

            }
            else
            {
                MessageBox.Show("Email or Password  is incorrect,please try again!");
                textemail.Clear();
                textpassword.Clear();
                textemail.Focus();

            }
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueToSearch = textemail.Text.ToString();
            string valueToSearch2 = textpassword.Text.ToString();
            searchData(valueToSearch, valueToSearch2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textemail.Text.ToString();
            string valueToSearch2 = textpassword.Text.ToString();
            searchData(valueToSearch, valueToSearch2);
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
    }
}
